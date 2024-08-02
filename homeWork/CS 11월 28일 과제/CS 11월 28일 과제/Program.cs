using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace CS_11월_28일_과제
{
    class Program
    {
        public static StreamWriter wr = null;
        public static StreamReader rd = null;

        private static void SendData()
        {
            String str;
            while (true)
            {
                str = Console.ReadLine();
                wr.WriteLine(str);
                wr.Flush();
                if (str == "Goodbye") break;
            }
        }

        private static void ReceiveData()
        {
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            string str;
            while (true)
            {
                byte[] data = new byte[1024];
                int size = client.Receive(data);
                str = Encoding.Default.GetString(data, 0, size);
                Console.WriteLine("수신" + str);
                if (str == "Goodbye") break;
            }
        }

        static void Main(string[] args)
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("10.109.9.13"), 8800);
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Console.WriteLine("서버에 접속 대기 중...");

            client.Connect(ipep);
            Console.WriteLine("연결 완료\n\n");

            byte[] data = new byte[1024];
            int size;
            string str;
            string send;
            while (true)
            {
                size = client.Receive(data);
                str = Encoding.Default.GetString(data, 0, size);
                Console.WriteLine("[수신]" + str);
                if (str == "Goodbye")
                    break;
                send = Console.ReadLine();

                client.Send(Encoding.Default.GetBytes(send));
                if (send == "Goodbye")
                    break;

            }
        }
    }
    
}

