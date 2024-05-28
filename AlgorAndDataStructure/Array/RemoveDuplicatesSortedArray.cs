using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AlgorAndDataStructure.Array
{
    public class RemoveDuplicatesSortedArray
    {


        public void ArrayRemoveDuplicated()
        {
            List<int[]> data = new List<int[]>();
            data.Add(new int[] { 1,1,2 });
            data.Add(new int[] { 0,0,1,1,1,2,2,3,3,4 });
        }
        private int RemoveDuplicates(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        
                        for (int k = j; k < nums.Length - 1; j++)
                        { 
                           
                        }
                    }

                }
            }
        }
    }
}
