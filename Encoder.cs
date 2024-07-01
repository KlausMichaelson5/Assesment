using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assement_Q1
{
    internal class Encoder
    {
        public static string Encode(string message)
        {
            if (message == null) throw new NullReferenceException("Please provide a string to encode.");

            if (message == "") throw new ArgumentException("Please provide a non empty string to encode.");

            Dictionary<char, string> letterCodes = CodeGenerater.GetLetterCodes();

            string result = "";
            for (int messageIndex = 0; messageIndex < message.Length; messageIndex++)
            {
                if (message[messageIndex] == ' ')
                {
                    result += '-';
                    continue;
                }
                result += GetCodeForLetter(message[messageIndex], letterCodes);
                if (messageIndex != message.Length - 1 && message[messageIndex + 1] != ' ')
                {
                    result += ',';
                }
            }

            return result;
        }

        private static string GetCodeForLetter(char letter, Dictionary<char, string> letterCodes)
        {
            letter = char.ToLower(letter);
            if (letterCodes.ContainsKey(letter))
            {
                return letterCodes[letter];
            }
            else
            {
               throw new ArgumentException("Please provide a alphabet to get its associated code.");
            }
        }
    }

}
