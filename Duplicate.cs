using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps
{
    class Duplicate
    {
       static  void  Main()
        {

            int[] array = { 1, 2, 2, 5, 7, 7, 9, 13, 3, 2 };
            //var dictionary = new Dictionary<int, int>();

            var dict = new Dictionary<int, int>();
            foreach (int item in array)
            {
                if (!dict.ContainsKey(item))
                    dict[item] = 0;
                dict[item]++;
            }

            foreach (var i in dict)
                if (i.Value > 1)
                    Console.WriteLine(i.Key + ",");
            Console.ReadLine();
        }

    }
}
