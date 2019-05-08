using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPointQuestions
{
    class Q1 // binary search tree
    {
       

        Node Root = new Node();

        public Node FindDeepestCommonRoot(Node root, Message m)
        {
            var from = Convert.ToInt32(m.From);
            var to = Convert.ToInt32(m.To);
            var current = root;
            while (current != null)
            {

                if (from < current.data && to < current.data)
                {
                    current = current.Left;
                }
                else
                {
                    if(from > current.data && to > current.data)
                    {
                        current = current.Right;
                    }
                    else
                    {
                        return current;
                    }
                }
            }

         return current; 
        }

        private bool FindAddress(Node root, string address)
        {
            var intAddress = Convert.ToInt32(address);
            var currnet = root;
            while (currnet != null)
            {
                if (intAddress == currnet.data)
                {
                    return true;
                }
                if (intAddress < currnet.data)
                {
                    currnet = currnet.Left;
                }
                else if (intAddress > currnet.data)
                {
                    currnet = currnet.Right;    
                }
            }
            return false;
        }
        
        public MessageStatus IsValidMessage(Node root, Message message)
        {
            var deepestRoot = FindDeepestCommonRoot(root, message);
            var from = message.From.ToString();
            var to = message.To.ToString();

            if (deepestRoot != null)
            {
                var fromAddressFound = FindAddress(root, from);
                var toAddressFound = FindAddress(root, to);

                if (fromAddressFound || toAddressFound)
                {
                    return MessageStatus.reject;
                }
                
                
            }
            return MessageStatus.accept;

        }
    }

    enum MessageStatus
    {
        accept = 1,
        reject = 2,
    }
}
