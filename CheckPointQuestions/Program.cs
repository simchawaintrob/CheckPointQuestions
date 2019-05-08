using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPointQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            var q4 = new Q4();
            var m1 = new Message("dana", "ron", "ello");
            q4.GetMSG(m1);
            Message sms1 = new Message("yoni", "kim", "nice");
            q4.GetMSG(sms1);
            Message sms2 = new Message("yoni", "bur", "juli");
            q4.GetMSG(sms2);
            Message sms3 = new Message("lol", "pp", "nice");
            q4.GetMSG(sms3);
            Message sms13 = new Message("lol", "pp", "nce");
            q4.GetMSG(sms13);
            Message sms4 = new Message("hadar", "kim", "nice");
            q4.GetMSG(sms4);
            Message sms5 = new Message("yoni", "kim", "nice");
            q4.GetMSG(sms5);
            Message sms6 = new Message("jim", "kim", "nice");
            q4.GetMSG(sms6);
            Message sms7 = new Message("kim", "kim", "nice");
            q4.GetMSG(sms7);
            Message sms8 = new Message("roni", "kim", "nice");
            q4.GetMSG(sms8);
            Message sms9 = new Message("asaf", "kim", "nice");
            q4.GetMSG(sms9);
            Message sms10 = new Message("ran", "kim", "nice");
            q4.GetMSG(sms10);

            // print the adresses that sent more or equal then ten persent of messages
            foreach (var item in q4.GetAllSendOverTenPercent())
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
