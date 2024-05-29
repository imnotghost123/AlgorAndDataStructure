using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorAndDataStructure.Array
{
    public class ContainsDuplicateII
    {
        //Given an integer array nums and an integer k, return true if there are two distinct indices i and j in the array such that nums[i] == nums[j] and abs(i - j) <= k.
        public void ContainsDuplocateIIJob()
        {
            List<int[]> data = new List<int[]>();
            data.Add(new int[] { 1, 2, 3, 1 }); //true , k =3
            data.Add(new int[] { 1, 0,1,1}); //true , k=1
            data.Add(new int[] { 1,2,3,1,2,3 }); //false k=2

            Console.WriteLine("The result of remove duplicates II value is {0}", DoTheJob(data[0],3));
            Console.WriteLine("The result of remove duplicates II value is {0}", DoTheJob(data[1], 1));
            Console.WriteLine("The result of remove duplicates II value is {0}", DoTheJob(data[2], 2));
            Console.ReadLine();
        }

        private bool DoTheJob(int[] nums, int k)
        {
            for(int i =0; i< nums.Length; i++) 
            {
                for(int j = i+1; j<nums.Length; j++) 
                {
                    if (nums[i] == nums[j])
                    {
                        if (Math.Abs(i - j) <= k)
                        {
                            continue;
                        }
                        else if(nums.Length-1 <= j) return false;
                    }
                }
            }

            return true;
        }
    }
}
