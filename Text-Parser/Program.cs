using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Parser
{
    class Program
    {

        // <summary>
        // FullAnalysis is a method in the TextAnalyzer class. It accepts any string and displays the relevant information in the console.
        // For this challenge, I have defined 'words' as any character string between white-spaces, and sentences as strings split between these punctuators: . ! ?
        // </summary>

        static void Main(string[] args)
        {
            TextAnalyzer tomsReader = new TextAnalyzer();

            var Text = "Call me Ishmael. Some years ago — never mind how long precisely — having little or no money in my purse, and nothing particular to interest me on shore, I thought I would sail about a little and see the watery part of the world. It is a way I have of driving off the spleen, and regulating the circulation. Whenever I find myself growing grim about the mouth; whenever it is a damp, drizzly November in my soul; whenever I find myself involuntarily pausing before coffin warehouses, and bringing up the rear of every funeral I meet; and especially whenever my hypos get such an upper hand of me, that it requires a strong moral principle to prevent me from deliberately stepping into the street, and methodically knocking people’s hats off — then, I account it high time to get to sea as soon as I can. This is my substitute for pistol and ball. With a philosophical flourish Cato throws himself upon his sword; I quietly take to the ship. There is nothing surprising in this. If they but knew it, almost all men in their degree, some time or other, cherish very nearly the same feelings towards the ocean with me.";


            var thirdLargestWord = string.Join(", ", tomsReader.ThirdLongestWord(tomsReader.ToWordArray(Text)).ToList());
            var thirdLargestWordCharCount = tomsReader.ThirdLongestWord(tomsReader.ToWordArray(Text)).Key;

            Console.WriteLine("There are {0} sentences.", tomsReader.ToSentenceArray(Text).Length);
            Console.WriteLine("There are {0} total words.", tomsReader.ToWordArray(Text).Length);
            Console.WriteLine("The longest sentence is: {0}", tomsReader.LongestSentence(tomsReader.ToSentenceArray(Text)));
            Console.WriteLine("The most frequently used word is: \"{0}\"", tomsReader.MostFrequentWord(tomsReader.ToWordArray(Text)));
            Console.WriteLine("The third longest word(s): {0}  Number of characters: {1}", thirdLargestWord, thirdLargestWordCharCount);
            Console.ReadLine();
        }
    }
}
