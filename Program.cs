using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Reduction20210910
{
    class Program
    {






        // Returns smallest possible length with given
        // operation allowed.
        static int stringReduction(String str)
        {
            int n = str.Length;

            // Counint occurrences of three different
            // characters 'a', 'b' and 'c' in str
            int[] count = new int[3];
            for (int i = 0; i < n; ++i)
            {
                count[str[i] - 'a']++;
            }

            // If all characters are same.
            if (count[0] == n || count[1] == n
                    || count[2] == n)
            {
                return n;
            }

            // If all characters are present even number
            // of times or all are present odd number of
            // times.
            if ((count[0] % 2) == (count[1] % 2)
                    && (count[1] % 2) == (count[2] % 2))
            {
                return 2;
            }

            // Answer is 1 for all other cases.
            return 1;
        }


        static void Main(string[] args)
        {



            String str = "abcbbaacb"; //  abcbbaacb = ccbbaacb = cabaacb = bbaacb = bcacb = aacb = abb = cb = a

            Console.WriteLine(stringReduction(str));

            Console.ReadLine();


        }
    }
}
