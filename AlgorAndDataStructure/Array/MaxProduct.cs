//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AlgorAndDataStructure.Array
//{
//    public class MaxProduct
//    {

//        public void MaxProductJob()
//        {
//            List<int[]> data = new List<int[]>();
//            data.Add(new int[] { 3,4,5,2 }); //If you choose the indices i=1 and j=2 (indexed from 0), you will get the maximum value, that is, (nums[1]-1)*(nums[2]-1) = (4-1)*(5-1) = 3*4 = 12. 
//            data.Add(new int[] { 1,5,4,5 }); //16
//            data.Add(new int[] { 3,7}); //12

//            Console.WriteLine("The result of remove duplicates II value is {0}", DoTheJob(data[0]));
//            Console.WriteLine("The result of remove duplicates II value is {0}", DoTheJob(data[1]));
//            Console.WriteLine("The result of remove duplicates II value is {0}", DoTheJob(data[2]));
//            Console.ReadLine();
//        }

//        private int DoTheJob(int[] nums)
//        {
//            int[] biggestTemp = new int[] { } ;
            
//            for(int i=0; i<nums.Length; i++)
//            {
//                biggestTemp[i] = nums[i];
//                for (int j = i + 1; j < nums.Length; j++)
//                {
                    
//                    if (nums[i] < nums[j])
//                    {
//                        biggestTemp[i] = j;
//                    }
                    
//                }
         
//            }

           
//        }

//    }
//}
