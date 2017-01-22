using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace SharedProject1
{
    class WriteReadMethods
    {
        private static readonly ASCIIEncoding asen = new ASCIIEncoding();


        public static void SendObjectMessage(BinaryWriter writer, object obj)
        {
            var bf = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                var message = ms.ToArray();
                writer.Write(BitConverter.GetBytes(message.Length));
                writer.Write(message);
            }
        }


        public static string ReadTextMessage(BinaryReader reader)
        {
            int packLen = reader.ReadInt32();
            byte[] bytes = reader.ReadBytes(packLen);
            string message = Encoding.ASCII.GetString(bytes);
            return message;
        }

        public static void SendTextMessage(BinaryWriter writer, string message)
        {
            byte[] jsonBytes = asen.GetBytes(message);

            writer.Write(BitConverter.GetBytes(jsonBytes.Length));
            writer.Write(jsonBytes);
        }

        //public static Sessions ReadObjectMessage(BinaryReader reader)
        //{
        //    try
        //    {
        //        var packLen = reader.ReadInt32();
        //        var bytes = reader.ReadBytes(packLen);

        //        using (Stream stream = new MemoryStream(bytes))
        //        {
        //            var bf = new BinaryFormatter();

        //            return (Sessions)bf.Deserialize(stream);
        //        }
        //    }
        //    catch (Exception e)

        //    {
        //        Console.WriteLine(e);
        //        return new Sessions();
        //    }
        //}


    }
}
