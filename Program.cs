using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using UDP;

namespace UDPConsole2019
{
    class Program
    {



    static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            IPAddress broadcast = IPAddress.Parse("127.0.0.1");

            byte[] sendbuf = Encoding.ASCII.GetBytes("hello");
            IPEndPoint ep = new IPEndPoint(broadcast, 6969);

            s.SendTo(sendbuf, ep);

            Console.WriteLine("Message sent to the broadcast address");
            UDPSocket K = new UDPSocket();
            K.Server("127.0.0.1", 27000);

            UDPSocket c = new UDPSocket();
            c.Client("127.0.0.1", 27000);
            c.Send("TEST!");

            Console.ReadKey();

        }
    }
}
