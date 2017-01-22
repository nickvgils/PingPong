using SharedProject1;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace WindowsFormsApplication1
{
    public partial class GameFrame : Form
    {


        private const string IpAdress = "127.0.0.1";
        private const int PortNumber = 6666;

        private bool isPlayer1 = false;

        private BinaryReader reader;
        private BinaryWriter writer;
        private bool opponentReady = false;

        private string gameName;

        #region setup dragBar

        private const int WmNclbuttondown = 0xA1;
        private const int HtCaption = 0x2;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd,
            int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        #endregion

        public GameFrame(string gameName)
        {
            this.gameName = gameName;

            KeyPreview = true;
            InitializeComponent();


            Connection();
        }


        private async void Connection()
        {

            try
            {
                TcpClient client = new TcpClient(IpAdress, PortNumber);
                reader = new BinaryReader(client.GetStream());
                writer = new BinaryWriter(client.GetStream());

                if (WriteReadMethods.ReadTextMessage(reader) == "player1")
                {
                    isPlayer1 = true;
                    AddToMessageBox("Hallo ! We wachten nog op een tegenstander... (systeem)");
                    await Task.Factory.StartNew(() => WriteReadMethods.ReadTextMessage(reader));
                    AddToMessageBox("\n Je medespeler is aangesloten, om te beginnen typ \"start\"!(systeem)");
                }
                else
                {
                    AddToMessageBox("Hallo, Je medespeler staat klaar om te beginnen! Om te beginnen typ \"start\" (systeem)");

                }

                sendingTextBox.Enabled = true;
                sendingButton.Enabled = true;
                scoreButton.Enabled = true;

                Console.WriteLine("Before Game is van start gegaan");
                WriteReadMethods.SendTextMessage(writer, gameName);
                Debug.WriteLine("GameN");

                await Task.Factory.StartNew(BeforeGame);


            }
            catch (Exception x)
            {

                Console.WriteLine(x);
            }

        }

        private void BeforeGame()
        {
            opponentReady = false;
            while (true)
            {              
                string message = WriteReadMethods.ReadTextMessage(reader);
                switch (message)
                {
                    case "start":
                        if (opponentReady)
                        {
                            Task.Factory.StartNew(InGame);
                        }
                        else
                        {
                            AddToMessageBox("\nJe medespeler heeft start verstuurd en wilt gaan spelen. Verstuur \"start\" terug om te beginnen! (systeem)");
                            opponentReady = true;
                        }
                        break;
                    case "stop":
                        AddToMessageBox(message);
                        continue; //score
                    case "score":         
                        string scoreData = WriteReadMethods.ReadTextMessage(reader);
                        List<GameInformation> gi = Newtonsoft.Json.JsonConvert.DeserializeObject<List<GameInformation>>(scoreData);
                        Console.WriteLine("score ontvangen");
                        new ScoreFrame(gi).ShowDialog();

                        continue;
                    default:
                        AddToMessageBox(message + " (Medespeler)");
                        continue;
                }
                break;
            }
        }

        private void InGame()
        {
                scoreButton.Invoke(new Action(() => scoreButton.Enabled = false));

            int speedRight = 15;
            int speedDown = 15;
            const int gameSpeed = 800;
            int score = 0;
            if (!isPlayer1)
            {
                speedRight = -speedRight;
                speedDown = -speedDown;
            }


            Timer timer2 = new Timer(1000);
            timer2.Elapsed += (source, e) =>
            {

                WriteReadMethods.SendTextMessage(writer, player1.Location.X + "");
                int number = int.Parse(WriteReadMethods.ReadTextMessage(reader));

                number = 240 + (480 - number);

                player2.Invoke(new Action(() => player2.Location = new Point(number, player2.Location.Y)));

            };

            Timer timer = new Timer(gameSpeed);
            timer.Elapsed += (source, e) =>
            {

                Console.WriteLine(ball.Location);
                ChangeBallLocation(new Point(ball.Location.X + speedRight, ball.Location.Y + speedDown));



                if (ball.Location.Y < 20 || ball.Location.Y > 510) // collision with the players rectangle
                {
                    if (ball.Location.Y > 510) //collision with your own rectangle
                    {
                        if (ball.Location.X > player1.Location.X - ball.Size.Width &&
                            ball.Location.X < player1.Location.X + player1.Size.Width + ball.Size.Width)
                        {
                            score++;
                            UpdateScore(score);
                            WriteReadMethods.SendTextMessage(writer, "right");
                        }
                        else
                        {
                            timer2.Stop();
                            WriteReadMethods.SendTextMessage(writer, "wrong");
                            ResetAfterGame(score);
                            timer.Stop();
                        }

                    }
                    else
                    {
                        Console.WriteLine("leest of tegenstander het goed heeft");
                        //teammate has left quesstion
                        string rightWrong = WriteReadMethods.ReadTextMessage(reader);
                        if (rightWrong == "right")
                        {
                            Console.WriteLine("tegenstander heeft het goed");
                            score++;
                            UpdateScore(score);
                        }
                        else
                        {
                            timer2.Stop();
                            Console.WriteLine("wrong");
                            WriteReadMethods.SendTextMessage(writer, "wrong2");
                            ResetAfterGame(score);
                            timer.Stop();
                        }



                    }

                    speedDown = -speedDown;
                    if (timer.Interval - 5 > 0 && timer.Enabled)
                    {
                        timer.Stop();
                        timer.Interval = timer.Interval - 50;
                        timer.Start();
                    }


                }
                if (ball.Location.X < 0 || ball.Location.X > 845) // collision with the left and right boundry
                {
                    speedRight = -speedRight;
                }


            };

            timer2.Start();
            timer.Start();
        }

        private void ResetAfterGame(int score)
        {
            UpdateScore(0);
            AddToMessageBox("\nHelaas! Jullie hebben een score neergezet van " + score + " punten, gefeliciteerd! Voor een rematch stuur \"start\" naar je medespeler. (system)");


            Invoke(new Action(() =>
            {
                sendingTextBox.Enabled = true;
                sendingButton.Enabled = true;
                player1.Location = new Point(360, 544);
                player2.Location = new Point(360, 4);
                gamePanel.Visible = false;
                ball.Location = new Point(424, 282);
                scoreButton.Enabled = true;
            }));



            Task.Factory.StartNew(BeforeGame);
        }

        private void UpdateScore(int score)
        {
            if (scoreLabel.InvokeRequired)
            {
                scoreLabel.Invoke(new Action(() => scoreLabel.Text = score + ""));
            }
            else
                scoreLabel.Text = score + "";

        }

        private void AddToMessageBox(string message)
        {
            Console.WriteLine(message);
            if (messagesBox.InvokeRequired)
                messagesBox.Invoke(new Action(() => messagesBox.Text += message));
            else
            {
                messagesBox.Text += message;
            }
        }


        private void ChangeBallLocation(Point location)
        {
            if (ball.InvokeRequired)
                messagesBox.Invoke(new Action(() => ball.Location = location));
            else
            {
                ball.Location = location;
            }
        }









        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ReleaseCapture();
            SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sendingTextBox.Text == "start")
            {
                sendingTextBox.Enabled = false;
                sendingButton.Enabled = false;
                gamePanel.Visible = true;
                AddToMessageBox("\n" + sendingTextBox.Text);

                WriteReadMethods.SendTextMessage(writer, sendingTextBox.Text);

                sendingTextBox.Text = "";
                scoreButton.Enabled = false;


                if (opponentReady)
                {
                    AddToMessageBox("\n Het spel is begonnen sending. (systeem)");
                    Task.Factory.StartNew(InGame);
                }
                else
                {
                    opponentReady = true;
                }



            }
            else
            {
                AddToMessageBox("\n " + sendingTextBox.Text);
                WriteReadMethods.SendTextMessage(writer, sendingTextBox.Text);
                sendingTextBox.Text = "";
            }
        }

        //processing keyevents
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left && player1.Location.X - 10 >= 0)
            {
                player1.Location = new Point(player1.Location.X - 10, player1.Location.Y);
            }
            if (keyData == Keys.Right && player1.Location.X + 10 <= 722)
            {
                player1.Location = new Point(player1.Location.X + 10, player1.Location.Y);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void sendingTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            button1_Click(sender, e);
            sendingTextBox.Text = "";
        }

        private void sendingTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            sendingTextBox.Text = "";

        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            panel1_MouseDown(sender, e);
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {

            WriteReadMethods.SendTextMessage(writer, "score");
          
        }
    }


}
