using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyser
{
    class TextAnalyser
    {
        PorterStemmerAlgorithm.PorterStemmer myStemmer; // for Activity 4,5
        System.Collections.Generic.Dictionary<string, int> tokenCount; // for Activity 5

        public TextAnalyser()
        {
            myStemmer = new PorterStemmerAlgorithm.PorterStemmer();
            tokenCount = new Dictionary<string,int>();
        }

        //Activity 3
        /// <summary>
        /// Convert the  given text into tokens and then splits it into tokens according to whitespace and punctuation. 
        /// </summary>
        /// <param name="text">Some text</param>
        /// <returns>Lower case tokens</returns>
        public string[] TokeniseString(string text)
        {   // define some delimiters 
            char[] splitters = new char[] {',',' ','-','\' };
            string[] output = text.Split(splitters);
            return output;
            //transform to lower case 
            // split the text 
            // stub
            return new string[0];
        }

        /// <summary>
        /// Prints out tokens for a given text string
        /// </summary>
        /// <param name="str">a string of text</param>
        public void OutputTokens(string str)
        {
            System.Console.WriteLine("Orginal: \"" + str + "\"");
            string[] tokens = TokeniseString(str);
            Console.WriteLine("Tokens: ");
            foreach (string t in tokens)
            {
                System.Console.WriteLine(t);
            }
        }

        static void Main(string[] args)
        {


            TextAnalyser textAnalyser = new TextAnalyser();

            System.Console.WriteLine("Activity 3");
            string text1 = "Tokenising, even in english, is a difficult problem. It's even harder in other languages - such as Chinese!";
            textAnalyser.OutputTokens(text1);
            
             System.Console.ReadLine();

        }



    }
}
