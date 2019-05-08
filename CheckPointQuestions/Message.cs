using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPointQuestions
{
    class Message
    {
        public string To { get; set; }
        public string From  { get; set; }
        public string Data { get; set; }
        public Message(string from,string to,string msg)
        {
            To = to;
            From = from;
            Data = msg;
        }
    }
}
