using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorAndDataStructure.Array
{
    public class TwoSumII
    {
        public void TwoSumIIJob()
        {
            List<int[]> data = new List<int[]>();
            data.Add(new int[] { 2, 7,11,15 }); // target =9  , [1,2]
            data.Add(new int[] { 2,3,4 }); //6 [1,3]
            data.Add(new int[] { -1,0}); //-1 [-1,0]

            Console.WriteLine("The result of TwoSumIIJob value is {0}", DoTheJob(data[0], 9));
            Console.WriteLine("The result of TwoSumIIJob value is {0}", DoTheJob(data[1], 6));
            Console.WriteLine("The result of TwoSumIIJob value is {0}", DoTheJob(data[2], -1));
            Console.ReadLine();
        }

        private int[] DoTheJob(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    { 
                        return new int[] { i, j };
                    }
                }

            }

            return new int[] { };
        }
    }
}
