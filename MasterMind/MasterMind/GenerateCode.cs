using System;
using System.Collections.Generic;
using System.Text;


namespace MasterMind
{
    public class GenerateCode : IGenerateCode
    {
        private int intCode;

        public String Code{ get; set;}

        public void RandomCode()
        {
            Random randNumber = new Random();
            int[] intCode = new int[4];
            for (int i = 0; i < 4; i++)
            {
                intCode[i] = randNumber.Next(1, 7) ;
            }
             
            Code = string.Join("",intCode) ;    
        }
    }
}
