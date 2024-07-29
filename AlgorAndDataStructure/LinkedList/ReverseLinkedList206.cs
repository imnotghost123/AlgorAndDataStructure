using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorAndDataStructure.LinkedList
{
    public class ReverseLinkedList206
    {

        public static void ReverseLinkedList206Job() 
        {
            //ListNode head = new ListNode(5);
            //head.next = new ListNode(4);
            //head.next.next = new ListNode(3);
            //head.next.next.next = new ListNode(2);
            //head.next.next.next.next = new ListNode(1);

            ListNode head = new ListNode(5);
            ListNode head1 = new ListNode(4);
            ListNode head2 = new ListNode(3);
            ListNode head3 = new ListNode(2);
            ListNode head4 = new ListNode(1);

            head.next = head1;
            head1.next = head2;
            head2.next = head3;
            head3.next = head4;
            ListNode data = DoTheJob(head);
            PrintList(data);
        }

        private static ListNode DoTheJob(ListNode head)
        {
            
            ListNode cur = head;
            ListNode prev = null;
            ListNode next = null;

            while (cur != null)
            {
                next = cur.next;
                cur.next = prev;
                prev = cur;
                cur = next;
            }

            return prev;
            //ListNode cur = head;
            //ListNode prev = null;
            //ListNode nxt = null;

            //while (cur != null) 
            //{
            //    nxt = cur.next;
            //    cur.next  = prev;
            //    prev = cur;
            //    cur = nxt;
            //}

            //return prev;
        }

        private static void PrintList(ListNode node)
        {
            while (node != null)
            {
                Console.Write(node.val + " ");
                node = node.next;
            }
            Console.WriteLine();
        }
    }



}
