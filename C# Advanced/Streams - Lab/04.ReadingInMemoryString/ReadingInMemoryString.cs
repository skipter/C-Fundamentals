using System;
using System.Text;

namespace _04.ReadingInMemoryString
{
    class ReadingInMemoryString
    {
        static void Main()
        {
            string text = "In-memory text.";
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            using (var memoryStream = new System.IO.MemoryStream(bytes))
            {
                while (true)
                {
                    int readByte = memoryStream.ReadByte();
                    if (readByte == -1)
                        break;
                    Console.WriteLine((char)readByte);
                }
            }

        }
    }
}
