using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorAndDataStructure.TwoPointer
{
    public class JudSquareSum
    {
        public void JudSquareSumJob()
        {


            Console.WriteLine("The result of TwoSumIIJob value is {0}", DoTheJob(5));
            Console.ReadLine();
        }

        private bool DoTheJob(int c)
        {
            int i = 0;
            int j = (int) Math.Sqrt(c);

            while (i < j)
            {
                if ((i * i ) + (j *j) == c)
                {
                    return true;
                }
                else if (c<j)
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }

            return false;
        }
    }
}
