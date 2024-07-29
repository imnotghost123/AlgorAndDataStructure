using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AlgorAndDataStructure.LinkedList
{
    public class ListNode
    {
        public int val ;
        public ListNode? next;

        public ListNode(int x, ListNode next =null) 
        {
            val = x;
            this.next = next;
        }

        
    }
}
