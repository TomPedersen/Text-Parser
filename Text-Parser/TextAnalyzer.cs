using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Text_Parser
{
    class TextAnalyzer
    {
        public string RemoveAllPunctuation ( string text )
        {
            return Regex.Replace(text, @"[^\w\s]", "");
        }

        public string[] ToSentenceArray (string text) 
        {
            return Regex.Split(text, @"(?<=[\.!\?])\s+");
        }

        public string LongestSentence (string[] text)
        {
            return text.OrderByDescending(s => s.Length).First();
        }

        public string[] ToWordArray (string text)
        {
            return RemoveAllPunctuation(text).Split(' ');
        }

        public string MostFrequentWord (string[] text)
        {
            return text.GroupBy(w => w).OrderByDescending(g => g.Count()).First().Key;
        }

        public string ThirdLongestWord(string[] text)
        {
            var thirdWord = text.OrderByDescending(t => t.Count()).GroupBy(t => t.Length).Skip(2).First().ToList();
            return string.Join(", ", thirdWord);
        }

        public int ThirdLongestWordCharCount(string[] text)
        {
            var thirdWord = text.OrderByDescending(t => t.Count()).GroupBy(t => t.Length).Skip(2).First();
            return thirdWord.Key;
        }

    }


}
