using encoder;
using System;

namespace Encoder
{
    public class EncoderProcessor
    {
        public string Encode(string message)
        {

            string replacedString = String.Empty;
            //replace the numbers in reverse
            string encodedString = EncoderDefinitions.EncryptedNumbers(message);
           
            foreach (char obj in encodedString.ToLower())
            {
                //Check if the char is not a number
                char item = obj;
                if (!Char.IsNumber(obj))
                {
                    item = EncoderDefinitions.EncryptedChar(obj);
                    
                }
                replacedString += item;

            }
            Console.WriteLine("Replaced String :: " + replacedString);
            return replacedString;
           

           
            
        }

 
    }
}