using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace CS_11월_28일_실습
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 8800);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(ipep);
            server.Listen(5);

            Console.WriteLine("서버 시작... 클라이언트 한조 대기중...");

            Socket client = server.Accept();
            IPEndPoint ip = (IPEndPoint)client.RemoteEndPoint;

            Console.Write($"{ip.Address} 클라이언트 주소, {ip.Port} 포트 접속");

            byte[] data = Encoding.Default.GetBytes("주인님이 접속 했습니다. I'm 아이언맨");
            client.Send(data, data.Length, SocketFlags.None);
            data = new byte[1024];

            //if (client.Receive(data) != 0)
            //    Console.WriteLine("수신 메세지 : " + Encoding.Default.GetString(data));
            //else
            //    Console.WriteLine("수신 데이터 없음...");

            while (true)
            {
                int size = client.Receive(data);

                string str = Encoding.Default.GetString(data, 0, size);
                Console.WriteLine("[철홍] : " + str);
                if (str == "Goodbye") break;

                Console.Write("[서버] : ");
                string send = Console.ReadLine();
                client.Send(Encoding.Default.GetBytes(send));
                if (send == "Goodbye") break;


            }
            //if (size > 0)
            //    Console.WriteLine("수신 데이터 : " + Encoding.Default.GetString(data, 0, size));
            //else
            //    Console.WriteLine("수신 데이터 없음...");

            client.Close();
            server.Close();
        }
    }
}
 