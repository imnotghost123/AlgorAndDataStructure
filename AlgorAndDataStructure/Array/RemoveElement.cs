using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorAndDataStructure.Array
{
    public class RemoveElement
    {
        public void RemoveElementTest()
        {
            List<int[]> data = new List<int[]>();
            List<int[]> valData = new List<int[]>();
            data.Add(new int[] { 3,2,2,3 }); //output =1, nums={3,3}
            data.Add(new int[] { 0,1,2,2,3,0,4,2}); //output =5, nums={0,1,3,0,4}

            Console.WriteLine("The result from remove element test is {0}", ToDoJob(data[0],2));
            Console.ReadLine();
        }

        private int ToDoJob(int[]nums, int val)
        {
            //int j = 1;
            //for(int i = 1; i < nums.Length; i++) 
            //{
            //    if (nums[i] != val)
            //    {
            //        j++;
            //    }
            //}

            //return j;

            int index = 0;

            for(int i=0;i< nums.Length; i++)
            {

                if (nums[i]!=val)
                {
                    nums[index] = nums[i];
                    index++;
                }
                else 
                {
                    nums[i] = 0;
                }

            }
            return index;
        }
    }

    
}
