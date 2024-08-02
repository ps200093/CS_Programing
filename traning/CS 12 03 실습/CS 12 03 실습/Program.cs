using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CS_12_03_실습
{
    class Program
    {
        private static void SendData()
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("10.109.15.12"), 7000);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            byte[] data;
            String str;
            while (true)
            {
                Console.Write("메시지 : ");
                //str = Console.ReadLine();
                str = "test sentence";
                data = Encoding.Default.GetBytes(str);
                if (str == "Goodbye") break;

                server.SendTo(data, data.Length, SocketFlags.None, (EndPoint)ipep);
                
            }
        }

        private static void ReceiveData()
        {
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            byte[] data = new byte[1024];
            IPEndPoint sender = new IPEndPoint(IPAddress.Parse("10.109.15.12"), 7000);
            EndPoint remote = (EndPoint)sender;
            int recv = server.ReceiveFrom(data, ref remote);
            String str;
            while (true)
            {
                Console.Write("[수신]");
                str = Encoding.Default.GetString(data);
                Console.WriteLine("[수신] " + str);
                if (str == "Goodbye") break;

            }
        }

        static void Main(string[] args)
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("10.109.15.12"), 7000);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);


            Console.WriteLine("UDP 서버 접속 성공");
            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
            EndPoint remote = (EndPoint)(sender);

           Console.WriteLine("연결되었습니다.");
            Console.WriteLine("[수신] " + streamReader.ReadLine());
            Thread swThread = new Thread(new ThreadStart(SendData));
            Thread srThread = new Thread(new ThreadStart(ReceiveData));
            swThread.Start();
            srThread.Start();
            swThread.Join();
            srThread.Join();
            server.Close();
        }
    }
}
