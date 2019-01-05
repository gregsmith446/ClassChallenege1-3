using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var callClass = new GetString();

            callClass.getWords("teststring");
        }
    }

    class GetString
    {
        public void getWords(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                var letter = s[i];
                // prints all the letters from the string
                // Console.WriteLine(letter);

                for (int j = 0; j < s.Length; j++)
                {
                    if (s[i] == letter)
                    {
                        Console.WriteLine("true");
                    }
                }
            }
        }       
    }
}
