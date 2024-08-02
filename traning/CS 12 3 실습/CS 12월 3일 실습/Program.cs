using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CS_12월_3일_실습
{
    class Program
    {
        public static void sendData(Socket server, EndPoint endPoint)
        {
            string str;
            while (true)
            {

                str = Console.ReadLine();
                
                byte[] message = Encoding.Default.GetBytes(str);
                byte[] length = new byte[4];
                length = BitConverter.GetBytes(message.Length);
                server.SendTo(length, length.Length, SocketFlags.None, endPoint);
             

                server.SendTo(message, message.Length, SocketFlags.None, endPoint);
                if (str == "Goodbye")
                {
                    break;
                }
            }
        }
        public static void receivedData(Socket server, EndPoint endPoint)
        {
            string str;
            while (true)
            {
                byte[] length = new byte[4];
                int getMessageLength = server.ReceiveFrom(length, ref endPoint);
                int messageLength = BitConverter.ToInt32(length, 0);
               
            
                byte[] messageReceived = new byte[messageLength];
                int getMessage = server.ReceiveFrom(messageReceived, ref endPoint);
                str = Encoding.Default.GetString(messageReceived, 0, getMessage);


                Console.WriteLine("[수신]" + str);
                if (str == "Goodbye")
                {
                    break;
                }
            }
        }
        static void Main(string[] args)
        {

            byte[] openConnectMessage = new byte[1024];
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("10.109.248.35"), 8000);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);


            openConnectMessage = Encoding.Default.GetBytes("연결연결연결연결연결");
            server.SendTo(openConnectMessage, openConnectMessage.Length, SocketFlags.None, ipep);
            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
            EndPoint remote = (EndPoint)(sender);
            openConnectMessage = new byte[1024];
            int recv_size = server.ReceiveFrom(openConnectMessage, ref remote);
            Console.WriteLine(Encoding.Default.GetString(openConnectMessage, 0, recv_size));

            Thread sdThread = new Thread(new ThreadStart(() => sendData(server, remote)));
            Thread rdThread = new Thread(new ThreadStart(() => receivedData(server, remote)));
            sdThread.Start();
            rdThread.Start();
            sdThread.Join();
            rdThread.Join();

            server.Close();
        }

    }
}

