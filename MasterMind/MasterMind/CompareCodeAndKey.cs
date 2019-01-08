using System;
using System.Collections.Generic;
using System.Text;

namespace MasterMind
{
    public class CompareCodeAndKey : ICompareCodeAndKey
    {
        private char[] keyout;

        public bool KeyMatches { get; set; }
        


        public void CompareCodes(char[] chrCode, char[] chrKey)
        {
            keyout = new char[4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (chrKey[i] == chrCode[j])
                    {
                        //Console.WriteLine(chrKey[i] + " | " + chrCode[j]);
                        //keyout[i] = i == j ? '+' : '-';
                        if( i == j )
                        {
                            keyout[i] = '+';
                            break;
                        }
                        else if( i!= j && chrKey[i] != chrCode[i])
                        {
                            keyout[i] = '-';
                            break;
                        }
                        else
                        {
                            continue;
                        }
                        
                    }
                }
            }
            
            PrintResults();

            if (keyout[0] == '+' && keyout[1] == '+' && keyout[2] == '+' && keyout[3] == '+')
            {
                KeyMatches = true;
            }
        }

        private void PrintResults()
        {
            Console.Write("----> Compare results {");
            for (int i = 0; i < 4; i++)
            {
                if (keyout[i] == '+')
                {
                    Console.Write("+");
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (keyout[i] == '-')
                {
                    Console.Write("-");
                }
            }
            Console.WriteLine("}");
        }
    }
}
