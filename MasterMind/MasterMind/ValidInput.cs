using System;
using System.Collections.Generic;
using System.Text;

namespace MasterMind
{
    public class ValidInput : IValidInput
    {
        private int intNmbr;
        
        public bool InputValid { get; set; }
        public int KeyEntered { get; set; }
        
        
        public void ValidateInput(string strKey)
        {
            //InputValid = Int32.TryParse(strKey, out intNmbr);
            bool success = Int32.TryParse(strKey, out intNmbr);
            if (!success)
            {
                Console.WriteLine("Key not a number; Retry!");
                InputValid = false;
            }
            /*
             * check key length > 999 & < 9999
             * Since no restrictions on player entered combination 
             * key can be 1111 to 9999
             */ 
            else if ( intNmbr < 999 || intNmbr > 9999 )
            {
                Console.WriteLine("Key must be 4 digits and greater then 0; Retry!");
                InputValid = false;
            }
            else
            {
                InputValid = true;
                KeyEntered = intNmbr;
            }
        }
    }
}
