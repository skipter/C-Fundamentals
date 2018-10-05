using System;
using System.IO;

namespace _04.CopyBinaryFile
{
    class CopyBinaryFile
    {
        static void Main()
        {
            string destinationFile = "..//..//..//..//files//copyMe.png"; //Route to file
            string resultOfCopyDestination = "..//..//..//..//files//copyMe_result.png";

            using (FileStream readFile = new FileStream(destinationFile, FileMode.Open))
            {
                long size = readFile.Length; //Can check file size.
                //Initial buffer.
                byte[] buffer = new byte[size];
                //Fill the buffer. If its not filled, picture wont show it, copy the fail but make an error.
                readFile.Read(buffer, 0, buffer.Length);

                //Copy file.
                using (FileStream writeFile = new FileStream(resultOfCopyDestination, FileMode.Create))
                {
                    writeFile.Write(buffer, 0, buffer.Length);
                }
            }
        }
    }
}
