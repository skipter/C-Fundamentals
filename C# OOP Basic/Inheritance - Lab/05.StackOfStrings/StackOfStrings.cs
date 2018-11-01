using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings : List<string>
    {
        private List<string> data;

        public void Push(string name)
        {
            data.Add(name);
        }

        public string Pop()
        {
            string item = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);
            return item;
        }

        public string Peek()
        {
            return data[data.Count - 1];
        }

        public bool IsEmpty()
        {
            return data.Count == 0;
        }
    }
}
