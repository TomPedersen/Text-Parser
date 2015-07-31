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
            return Regex.Replace(text, @"[^\w\s]", ""); //Removes all punctuation, only keeping words/numbers/whitespace
        }

        public string[] ToSentenceArray (string text) 
        {
            return Regex.Split(text, @"(?<=[\.!\?])\s+"); //Divides text into array by splitting at !, ? and . while keeping these punctuators
        }

        public string LongestSentence (string[] text)
        {
            return text.OrderByDescending(s => s.Length).First(); //Orders split sentence array by descending length and returns first(largest)
        }

        public string[] ToWordArray (string text)
        {
            return RemoveAllPunctuation(text).Split(' '); //Using the punctuation-free string, splits words at each whitespace
        }

        public string MostFrequentWord (string[] text)
        {
            return text.GroupBy(w => w).OrderByDescending(g => g.Count()).First().Key; //Creates a descending-by-size IGroup. Returns the first key
        }

        public IGrouping<int, string> ThirdLongestWord(string[] text)
        {
            var thirdWord = text.OrderByDescending(t => t.Count()).GroupBy(t => t.Length).Skip(2).First(); //Creates a descending-by-size/descending by count IGroup. Skips first two and takes the first, which is now the third largest.
            return thirdWord;
        }
    }


}
