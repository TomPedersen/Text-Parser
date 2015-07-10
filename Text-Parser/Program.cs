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
            TextAnalyzer TomsReader = new TextAnalyzer();

            var sampleText = "Hold your ground, hold your ground! Sons of Gondor, of Rohan, my brothers! I see in your eyes the same fear that would take the heart of me. A day may come when the courage of men fails, when we forsake our friends and break all bonds of fellowship, but it is not this day. An hour of wolves and shattered shields, when the age of men comes crashing down! But it is not this day! This day we fight! By all that you hold dear on this good Earth, I bid you stand, Men of the West!";

            TomsReader.FullAnalysis(sampleText);
        }
    }
}
