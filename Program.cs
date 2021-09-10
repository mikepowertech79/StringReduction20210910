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

            // Count occurrences of three different
            // characters 'a', 'b' and 'c' in str
            int[] count = new int[3];
            for (int i = 0; i < n; ++i)
            {

                //count[str[i] - 'a']++;




                int strI = str[i];

                int strA = 'a';

                int countI = strI - strA;


                count[countI] = count[countI] + 1;      //count[countI] += 1;   ==     //count[countI]++;


            }

            // If all characters are same.
            if (count[0] == n || count[1] == n || count[2] == n)
            {
                return n;
            }

            // If all characters are present even number
            // of times or all are present odd number of
            // times.
            if ((count[0] % 2) == (count[1] % 2) && (count[1] % 2) == (count[2] % 2))
            {
                return 2;
            }

            // Answer is 1 for all other cases.0
            return 1;
        }


        static void Main(string[] args)
        {



            String str = "abcbbaacb"; //  abcbbaacb = ccbbaacb = cabaacb = bbaacb = bcacb = aacb = abb = cb = a
            Console.WriteLine(stringReduction(str));

            String str01 = "abcabc"; //  Input: "abcabc"  abcabc      ccabc   cbbc   abc  cc
            Console.WriteLine(stringReduction(str01));

            String str02 = "cccccccccccccccccccccccccc"; //  Input: "abcabc"  abcabc      ccabc   cbbc   abc  cc
            Console.WriteLine(stringReduction(str02));


            String str03 = "abababababbbbaabbabbbbbcccaaaaabbcc"; //  Input: "abcabc"  abcabc      ccabc   cbbc   abc  cc
            Console.WriteLine(stringReduction(str03));


            String str04 = "caaaaaaabbbcabbbbbbc"; //  Input: "abcabc"  abcabc      ccabc   cbbc   abc  cc
            Console.WriteLine(stringReduction(str04));


            String str05 = "ccbbbbbbbbbbbbbbbbbbbbbbbbbbbc"; //  Input: "abcabc"  abcabc      ccabc   cbbc   abc  cc
            Console.WriteLine(stringReduction(str05));


            String str06 = "ccbaaaaaaaaaaaaaaaaabbbcc"; //  Input: "abcabc"  abcabc      ccabc   cbbc   abc  cc
            Console.WriteLine(stringReduction(str06));


            String str07 = "ccccbbbbbbbbbbbbbbbbbbbaaaaaaaaa"; //  Input: "abcabc"  abcabc      ccabc   cbbc   abc  cc
            Console.WriteLine(stringReduction(str07));

            String str08 = "ccccaaabbbababaababbaa"; //  Input: "abcabc"  abcabc      ccabc   cbbc   abc  cc
            Console.WriteLine(stringReduction(str08));


            String str09 = "aaaaaaaaaaaaaaaabbbbbbbaaaaaaaabbbabbababccccccccbbccccaccccb"; //  Input: "abcabc"  abcabc      ccabc   cbbc   abc  cc
            Console.WriteLine(stringReduction(str09));


            String str10 = "cccaaaaaaaaaaaaa"; //  Input: "abcabc"  abcabc      ccabc   cbbc   abc  cc
            Console.WriteLine(stringReduction(str10));

            String str11 = "cbbbbbbbbbbbbbbbccccccccccccccaaaaaaaaaccc"; //  Input: "abcabc"  abcabc      ccabc   cbbc   abc  cc
            Console.WriteLine(stringReduction(str11));

            String str12 = "ccccaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaabbbb"; //  Input: "abcabc"  abcabc      ccabc   cbbc   abc  cc
            Console.WriteLine(stringReduction(str12));

            Console.ReadLine();


        }
    }
}
