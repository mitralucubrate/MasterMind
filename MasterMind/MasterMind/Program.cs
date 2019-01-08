using System;

namespace MasterMind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a 4 digit key");

            GenerateCode generateCode = new GenerateCode();
            ValidInput validInput = new ValidInput();
            CompareCodeAndKey compareCodeAndKey = new CompareCodeAndKey();

            //Generate RandomCode 
            generateCode.RandomCode();
            char[] code = generateCode.Code.ToCharArray();

            int keyCounter = 0;
            int[] key = new int[4];
            do
            {
                string strKey = Console.ReadLine();
                
                //Validate Input
                validInput.ValidateInput(strKey);
                if (validInput.InputValid)
                {
                    //compare Code And Key
                    compareCodeAndKey.CompareCodes(code, strKey.ToCharArray());
                    //Console.WriteLine();
                    keyCounter++;

                    if ( compareCodeAndKey.KeyMatches )
                    {
                        break;
                    }
                }
            } while (keyCounter < 10);


            Console.WriteLine(compareCodeAndKey.KeyMatches ?
                "Congratulation, you broke the code!" : 
                "Sorry, you lost!");


            Console.ReadLine();
        }
    }
}

