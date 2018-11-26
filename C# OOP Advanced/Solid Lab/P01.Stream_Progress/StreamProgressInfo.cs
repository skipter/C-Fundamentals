using P01.Stream_Progress.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Stream_Progress
{
    public class StreamProgressInfo
    {
        private IStreamable streamableObject;

        public StreamProgressInfo(IStreamable streamableObject)
        {
            this.streamableObject = streamableObject;
        }

        public int CalculateCurrentPercent()
        {
            return (this.streamableObject.BytesSent * 100) / this.streamableObject.Length;
        }
    }
}
