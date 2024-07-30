using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorAndDataStructure.HashMap
{
    public class TestCRUD
    {

        public static void DoTheJob()
        {
            Dictionary<int, string> data = new Dictionary<int, string>()
            {
                {12836,"a" },
                {15937,"b"},
                {16750,"e" },
                {13276,"f"},
                {10583,"g"}
            };
            GetJob(data);
            AddJob(data);
            RemoveJob(data);
        }
        public static void GetJob(Dictionary<int,string> data)
        {
            foreach (var val in data)
            {
                Console.WriteLine(val.Key);
                Console.WriteLine(val.Value); 
            }

            Console.WriteLine("Get specific data {0}", data[12836]);
        }

        public static void AddJob(Dictionary<int, string> data)
        {
            data.Add(500,"ZZ");
        }

        public static void RemoveJob(Dictionary<int, string> data)
        { 
            data.Remove(13276);
        }
    }


}
