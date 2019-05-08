using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPointQuestions
{
    class Q4
    {
        public static int MSGCounter = 0;
        public Dictionary<string, int> AddressDictionary = new Dictionary<string, int>();
        public void GetMSG(Message message)
        {
            MSGCounter++;
            if (AddressDictionary.Keys.Contains(message.From.ToString()))
            {
                AddressDictionary[message.From.ToString()] = Convert.ToInt32(AddressDictionary[message.From.ToString()]) + 1;
            }
            else
            {
                AddressDictionary.Add(message.From.ToString(), 1);
            }
        }

        public HashSet<string> GetAllSendOverTenPercent()
        {
            var hashSet = new HashSet<string>();
            double TenPercent = MSGCounter * 0.1;
            foreach (var item in AddressDictionary)
            {
                if (item.Value >= TenPercent)
                {
                    hashSet.Add(item.Key.ToString());
                }

            }


            return hashSet;
        }
    }
}
