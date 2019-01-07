using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Given a string s, find and return the first instance of a non-repeating character in it.
// If there is no such character, return '_'.


namespace CodeChallenge
{
    class Program
    {
            static void Main(string[] args)
            {
                var callClass = new GetString();

                callClass.FindFirst("abacabad");
                //want result to be "c"
            }
        }

        class GetString
        {
            public char FindFirst(string s)
            {
                /*  convert given string to char array, but eliminates char duplicates only keeping one of each letter.
                 ex/ abacabad -> abcd  */
                char[] inputChar = s.Distinct().ToArray();

                // loop through each letter in distinct array
                // ex/ abcd
                foreach (char letter in inputChar)
                {
                    // count the instances of each letter in the original string
                    int count = s.Count(x => x == letter);

                    Console.WriteLine(count);

                    // if there is only 1 instance of that letter in both s(original) and inputChar(distinct)
                    // that means there is only 1 instance of that letter, it does not repeat
                    if (count == 1)
                    {
                        return letter; //return the letter that does not repeat and end loop
                    }
                }
                // otherwise, return the '_' to indicate there are no letter that don't repeat.
                return '_';
            }

        }
    }