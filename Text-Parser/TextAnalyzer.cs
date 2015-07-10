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
            return Regex.Split(text, @"(?<=[\.!\?])\s+"); //add .Length for sentence count
        }

        public string LongestSentence (string[] text)
        {
            return text.OrderByDescending(s => s.Length).First(); //uses ToSentenceArray
        }

        public string[] ToWordArray (string text)
        {
            return RemoveAllPunctuation(text).Split(' '); //add .Length for word count
        }

        public string MostFrequentWord (string[] text)
        {
            return text.GroupBy(w => w).OrderByDescending(g => g.Count()).First().Key; //uses ToWordArray Like: MostFrequentWord(ToWordAray(text));
        }

        public string ThirdLongestWord(string[] text)
        {
            return text.OrderByDescending(t => t.Count()).GroupBy(t => t.Length).Skip(2).First().ToString(); //Check the ToString part. And check thatthis works like above
        }

    }


}
