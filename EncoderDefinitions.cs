using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace encoder
{
    public static class EncoderDefinitions
    {
        private const char Space = ' ';

        private static readonly IDictionary<char, char> AlphabetMapping = new Dictionary<char, char>
        {
            {'a', '1'}, {'b', 'a'}, {'c', 'b'}, {'d', 'c'}, {'e', '2'}, {'f', 'e'}, {'g', 'f'},
            {'h', 'g'}, {'i', '3'}, {'j', 'i'}, {'k', 'j'}, {'l', 'k'}, {'m', 'l'}, {'n', 'm'},
            {'o', '4'}, {'p', 'o'}, {'q', 'p'}, {'r', 'q'}, {'s', 'r'}, {'t', 's'}, {'u', '5'},
            {'v', 'u'}, {'w', 'v'}, {'x', 'w'}, {'y', Space}, {'z', 'y'}, {Space, 'y'}
        };
        public static char EncryptedChar(this char character)
        {
            return AlphabetMapping.ContainsKey(character) ? AlphabetMapping[character] : character;
        }
        public static string EncryptedNumbers(string message)
        {
            string encryptedString = message;
            var numbersInString = Regex.Split(message, @"\D+");
            foreach (string numberInString in numbersInString.Where(str => !string.IsNullOrEmpty(str)))
            {
                encryptedString = encryptedString.Replace(numberInString, GenerateReverseNumber(numberInString));
            }

            return encryptedString;
        }
        private static string GenerateReverseNumber(string number)
        {
            var reverseNumber = string.Empty;
            int numberLength = number.Length - 1;
            while (numberLength >= 0)
            {
                reverseNumber += number[numberLength];
                numberLength--;
            }

            return reverseNumber;
        }
    }

   
}
