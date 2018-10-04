using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace _05.SimpleTCPServer
{
    class SimpleTCPServer
    {
        static void Main()
        {
            byte[] buffer = new byte[10]; //Size of bytes. Its important.
            var listener = new TcpListener(IPAddress.Loopback, 3080);
            listener.Start();
            Console.WriteLine("TCP Server listening on port 3080...");

            while (true)
            {
                using (var stream = listener.AcceptTcpClient().GetStream())
                {
                    int readBytes = stream.Read(buffer, 0, buffer.Length);

                    while (readBytes != 0) //With while, if statement is slow. while stream is diff from 0 read !
                    {
                        Console.Write(Encoding.UTF8.GetString(buffer, 0, readBytes)); //Take(readBytes).ToArray()

                        readBytes = stream.Read(buffer, 0, buffer.Length);
                    }

                    //Send message to the server, after receive the data.
                    var outputBuffer = Encoding.UTF8.GetBytes("Data received!"); 
                    stream.Write(outputBuffer, 0, outputBuffer.Length);

                    Console.WriteLine();
                }
            }
        }
    }
}
