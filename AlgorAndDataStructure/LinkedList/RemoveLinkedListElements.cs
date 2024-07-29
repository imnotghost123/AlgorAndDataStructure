using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorAndDataStructure.LinkedList
{
    public class RemoveLinkedListElements
    {
        public static void DoTheJob()
        {
            ListNodes2 node = new ListNodes2(1);
            ListNodes2 node2 = new ListNodes2(2);
            ListNodes2 node3 = new ListNodes2(6);
            ListNodes2 node4 = new ListNodes2(3);
            ListNodes2 node5 = new ListNodes2(4);
            ListNodes2 node6 = new ListNodes2(5);
            ListNodes2 node7 = new ListNodes2(6);

            node.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;
            node5.next = node6;
            node6.next = node7;

            int removeVal = 6;

           // ListNodes2 aa =RemoveElements(node, removeVal);

            while (node != null && node.val == removeVal) node = node.next;

            ListNodes2 cur = node;


            while (node != null && node.next != null)
            {
                if (node.next.val == removeVal)
                {
                    node.next = node.next.next;
                }
                else
                {
                    node = node;
                }
            }



            PrintList(cur);
        }

        private static void PrintList(ListNodes2 node)
        {
            while (node != null)
            {
                Console.Write(node.val + " ");
                node = node.next;
            }
            Console.WriteLine();
        }

        public static ListNodes2 RemoveElements(ListNodes2 head, int val)
        {
            if (head == null) return head;

            //if the first element is to be removed or all elements are same as val;
            while (head != null && head.val == val) head = head.next;

            ListNodes2 current = head;

            while (head != null && head.next != null)
            {
                if (head.next.val == val)
                {
                    head.next = head.next.next;
                }
                else
                    head = head.next;
            }
            return current;
        }
    }

    public class ListNodes2
    {
        public int val;
        //  public ListNodes2 prev;
        public ListNodes2 next;

        public ListNodes2(int val=0, ListNodes2 next = null)
        //   public ListNodes2(int val, ListNodes2 prev = null, ListNodes2 next = null)
        {
            this.val = val;
            //    this.prev = prev;
            this.next = next;
        }

    }



}
