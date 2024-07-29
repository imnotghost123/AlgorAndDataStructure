using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorAndDataStructure.LinkedList
{
    public class PalindromeLinkedList
    {
        public static void DoTheJob()
        { 
        
        }

        private static void PrintList(ListNode data)
        {
            while (data != null)
            {
                Console.Write(data.val);
                data = data.next;
            }
        }
    }


    public class ListNodes
    {
        public int val;

        public ListNodes? node;

        public ListNodes(int valData, ListNodes listNodes = null)
        {
            val = valData;
            node = listNodes;
        }
    }


}
