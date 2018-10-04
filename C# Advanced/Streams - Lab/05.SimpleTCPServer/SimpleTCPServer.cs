using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace _05.SimpleTCPServer
{
    class SimpleTCPServer
    {
        static void Main()
        {
            byte[] buffer = new byte[4096];
            var listener = new TcpListener(IPAddress.Loopback, 3080);
            listener.Start();

            while (true)
            {
                using (var stream = listener.AcceptTcpClient().GetStream())
                {
                    stream.Read(buffer, 0, buffer.Length);

                    Console.WriteLine(Encoding.UTF8.GetString(buffer));
                }
            }
        }
    }
}
