using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorAndDataStructure.LinkedList
{
    public class MergeTwoSortedList21
    {
        public static void DoTheJob()
        {
            ListNodes data1 = new ListNodes(1);
            data1.next= new ListNodes(2);
            data1.next.next= new ListNodes(4);

            ListNodes data2 = new ListNodes(1);
            data2.next= new ListNodes(3);
            data2.next.next= new ListNodes(4);


          //  ListNodes cur = 
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
