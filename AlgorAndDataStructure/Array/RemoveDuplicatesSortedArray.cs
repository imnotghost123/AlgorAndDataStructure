using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AlgorAndDataStructure.Array
{
    public class RemoveDuplicatesSortedArray
    {


        public void ArrayRemoveDuplicated()
        {
            List<int[]> data = new List<int[]>();
            data.Add(new int[] { 1,1,1,2 });
            data.Add(new int[] { 0,0,1,1,1,2,2,3,3,4 });

            Console.WriteLine("The result is {0}", RemoveDuplicates(data[0]));
        }
        private int RemoveDuplicates(int[] nums)
        {
            int j = 1;
            //for (int i = 0; i < nums.Length; i++)
            //{

            //    if (nums[i] != nums[i - 1 ])
            //    {
            //        nums[j] = nums[i];
            //        j++;
            //    }
            //}

            for (int i = 1; i < nums.Length; i++)
            {

                if (nums[i] != nums[i - 1])
                {
                    nums[j] = nums[i];
                    j++;
                }
            }

            return j;
        }
    }
}
