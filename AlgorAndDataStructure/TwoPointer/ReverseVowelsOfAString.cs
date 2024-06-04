using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorAndDataStructure.TwoPointer
{
    public class ReverseVowelsOfAString
    {
        public void ReverseVowelOfAStringJob()
        {
            List<string> data = new List<string>() ;
            data.Add("hello");
            data.Add("leetcode");


            Console.WriteLine("The result of ReverseVowelOfAStringJob value is {0}", DoTheJob(data[0]));
            Console.WriteLine("The result of ReverseVowelOfAStringJob value is {0}", DoTheJob(data[1]));
            Console.ReadLine();
        }

        private string DoTheJob(string s)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            int i = 0;
            int j = s.Length - 1;
            char[] result = new char[s.Length];
            while (i <= j)
            {
                 char ci = s[i];   
                char cj = s[j];
                if (!vowels.Contains(ci))
                {
                    result[i++] = ci;
                }
                else if (!vowels.Contains(cj))
                {
                    result[j--]= cj;
                }
                else
                {
                    result[i++] = cj;
                    result[j--] = ci;
                }

           
            }
            return new String(result);
            //for (int i = 0; i < vowels2.Length; i++)
            //{
            //    for (int j =  vowels2.Length; j > i; j--)
            //    {
            //        if (vowels2[i] == vowels.)
            //    }
            //}
        }
    }
}
