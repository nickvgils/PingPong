using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using SharedProject1;

namespace Server
{
    class Server
    {
        private static readonly ASCIIEncoding asen = new ASCIIEncoding();
        private const string IpAdress = "127.0.0.1";
        private const int PortNumber = 6666;

        private readonly List<GameInformation> lijst;


        private Server()
        {
            lijst = Newtonsoft.Json.JsonConvert.DeserializeObject<List<GameInformation>>(File.ReadAllText("Data.json"));
                
               Connection();
            
        }

        private void Connection()
        {
            try
            {
                TcpListener listener = new TcpListener(IPAddress.Parse(IpAdress), PortNumber);

                listener.Start();
                Console.WriteLine("Server opgestart");

                while (true)
                {
                    Console.WriteLine("Wachten op speler 1");
                    TcpClient client = listener.AcceptTcpClient();
                    BinaryWriter writerTcp = new BinaryWriter(client.GetStream());
                    WriteReadMethods.SendTextMessage(writerTcp, "player1");

                    Console.WriteLine("Wachten op speler 2");
                    TcpClient client2 = listener.AcceptTcpClient();

                    BinaryWriter writerTcp2 = new BinaryWriter(client2.GetStream());
                    WriteReadMethods.SendTextMessage(writerTcp, "beginMsg");
                    WriteReadMethods.SendTextMessage(writerTcp2, "player2");



                    HandleSession(client, client2);
                }
            }
            catch (Exception x)
            {
                Console.WriteLine(x);
            }
        }

        private void HandleSession(TcpClient tcp, TcpClient tcp2)
        {
            BinaryReader readerTcp = new BinaryReader(tcp.GetStream());
            BinaryWriter writerTcp = new BinaryWriter(tcp.GetStream());
            BinaryReader readerTcp2 = new BinaryReader(tcp2.GetStream());
            BinaryWriter writerTcp2 = new BinaryWriter(tcp2.GetStream());

            string name = WriteReadMethods.ReadTextMessage(readerTcp);
            string name2 = WriteReadMethods.ReadTextMessage(readerTcp2);
            Console.WriteLine(name + name2 + "Dit zijn de gamenamen");

            while (true)
            {
                Console.WriteLine("sessie is gestart");
           


                //game logic

                //BeforeGame


                var t = Task.Factory.StartNew(() => BeforeGameHandle(readerTcp, writerTcp2, writerTcp));
                var t2 = Task.Factory.StartNew(() => BeforeGameHandle(readerTcp2, writerTcp, writerTcp2));


                Task.WaitAll(t, t2);


                Console.WriteLine("BeforeGameMethods Stopped");

                //ingame

             
                Task<int> a = Task.Factory.StartNew(() => InGameHandle(readerTcp, writerTcp2));

                Task<int> a2 = Task.Factory.StartNew(() => InGameHandle(readerTcp2, writerTcp));


                GameInformation result = new GameInformation
                {
                    Player1 = name,
                    Player2 = name2
                };


                Task.WaitAll(a, a2);

                Console.WriteLine("potje afgelopen");

                int score = a.Result + a2.Result;

                result.Score = score;

                lijst.Add(result);


                File.WriteAllText("Data.json", Newtonsoft.Json.JsonConvert.SerializeObject(lijst));


                Console.WriteLine("begin opnieuw");
            }
        }

        private static int InGameHandle(BinaryReader readerTcp2, BinaryWriter writerTcp)
        {
            int score = 0;
            bool gameOver = false;

            while (true)
            {
                Console.WriteLine("leest voor rightwrong");
                var rightWrong = WriteReadMethods.ReadTextMessage(readerTcp2);
                Console.WriteLine(rightWrong + "command inGame");
                switch (rightWrong)
                {
                    case "right":
                        Console.WriteLine("goed");
                        WriteReadMethods.SendTextMessage(writerTcp, rightWrong);
                        Console.WriteLine("sended to other player");
                        score++;
                        break;
                    case "wrong":
                        WriteReadMethods.SendTextMessage(writerTcp, rightWrong);
                        Console.WriteLine("Wrong---");
                        gameOver = true;
                        break;
                    default:
                        WriteReadMethods.SendTextMessage(writerTcp, rightWrong);     
                        break;
                    case "wrong2":
                        gameOver = true;
                        Console.WriteLine("Wrong2---");
                        break;
                }
                if (gameOver)
                {
                    Console.WriteLine("gameover");
                    break;
                }

                
              
            }

            Console.WriteLine(score + " <-- score");
            return score;

            

        }


        private void BeforeGameHandle(BinaryReader readerTcp, BinaryWriter writerTcp2, BinaryWriter writerTcp)
        {
            while (true)
            {
                Console.WriteLine("leest voor command");
                string message = WriteReadMethods.ReadTextMessage(readerTcp);
                Console.WriteLine(message);
                switch (message)
                {
                    case "start":
                        Console.WriteLine("startcommand doorsturen");
                        WriteReadMethods.SendTextMessage(writerTcp2, "start");
                        Console.WriteLine("startcommand verzonden");
                        break;
                    case "score":
                        WriteReadMethods.SendTextMessage(writerTcp, "score");
                        WriteReadMethods.SendTextMessage(writerTcp, Newtonsoft.Json.JsonConvert.SerializeObject(lijst));
                        Console.WriteLine("score verstuurd");
                        continue;

                    default:
                        Console.WriteLine("berichtcommand");
                        WriteReadMethods.SendTextMessage(writerTcp2, "\n" + message);
                        Console.WriteLine("bericht verzonden");
                        continue;
                }
                break;
            }
        }


        private static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            new Server();
        }

    }


}
