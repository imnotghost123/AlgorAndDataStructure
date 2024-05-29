using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorAndDataStructure.Array
{
    public class ContainsDuplicate
    {
        public void ContainsDuplicateJob()
        {
            List<int[]> data = new List<int[]>();
            data.Add(new int[] {1,2,3,1 }); //true
            data.Add(new int[] { 1,2,3,4}); //false
            data.Add(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 });

            Console.WriteLine("The result of remove duplicates sirted array is {0}", DoTheJob(data[2]));
            Console.ReadLine();
        }

        private bool DoTheJob(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            { 
                for(int j=i+1; j< nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                        return true;
                }
            }
            return false;
        }
    }
}
