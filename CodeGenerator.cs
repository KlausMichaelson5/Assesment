using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assement_Q1
{
    internal class CodeGenerater
    {
        private static string sentence = "The quick and brown fox jumps over the Lazy Dog";

        private static Dictionary<char, string> letterCodes = GenerateCode(sentence);

        private static Dictionary<char, string> GenerateCode(string sentence)
        {
            Dictionary<char, string> letterCodes = new Dictionary<char, string>();
            string[] wordsList = sentence.Split(' ');
            for (int wordIndex = 0; wordIndex < wordsList.Length; wordIndex++)
            {
                string word = wordsList[wordIndex];
                for (int letterIndex = 0; letterIndex < word.Length; letterIndex++)
                {
                    if (!letterCodes.ContainsKey(word[letterIndex]))
                    {
                        string code = $"{wordIndex}{letterIndex}";
                        letterCodes[word[letterIndex]] = code;
                    }
                }
            }
            return letterCodes;
        }

        public static Dictionary<char, string> GetLetterCodes() => letterCodes;

    }
}
