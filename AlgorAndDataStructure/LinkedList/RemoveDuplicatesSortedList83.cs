using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AlgorAndDataStructure.LinkedList
{
    public class RemoveDuplicatesSortedList83
    {
        public static void DoTheJob()
        {
            ListNodes head = new ListNodes(2);
            head.next = new ListNodes(1);
            head.next.next = new ListNodes(2);
            head.next.next.next = new ListNodes(3);
            head.next.next.next.next = new ListNodes(2);

            //while (head != null ) head = head.next;

            ListNodes cur = head;
            ListNodes next = head.next;

            while (head.next != null ) {

                if (head.val == next.val)
                {
                    head.next = next.next;
              //      cur=next;   
                    next= head.next;
                }
                else
                {
                    next = head.next;
                    head = next;
                    next = head.next;

                    //next = head.next;
                    //head = next.next;
                  //  cur = next;
                   // head = next;
                  //  next = head.next;
                }
            }

            PrintList(cur);
        }

        private static void PrintList(ListNodes node)
        {
            while (node != null)
            {
                Console.Write(node.val + " ");
                node = node.next;
            }
            Console.WriteLine();
        }

        private class ListNodes
        {
            public int val;
            public ListNodes next;

            public ListNodes(int val, ListNodes next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }


}
