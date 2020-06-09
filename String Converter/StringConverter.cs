using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;

namespace String_Converter
{
    class StringConverter
    {
        public static string Reverse(string str)
        {
            char[] characterArray = str.ToCharArray();
            Array.Reverse(characterArray);
            return new string(characterArray);
        }

        public static bool IsPalindrome(string str)
        {

            str = str.Trim(); // remove whitespaces around the sentence
            str = str.Replace(" ", ""); // remove spaces in the sentence
            str = str.Replace(",", ""); // remove punctuation in the sentence
            str = str.Replace("\"", ""); // remove punctuation in the sentence
            str = str.Replace(".", ""); // remove punctuation in the sentence
            str = str.ToLower(); // convert all characters to lowercase
            
            char[] characterArray = str.ToCharArray();
            
            int palindromeTrueCounter = 0; // I use this to check for every letter if it its opposite on the other side of the string is the same

            for (int i = 0; i < characterArray.Length; i++ )
            {
                if (characterArray[i] == characterArray[characterArray.Length - i - 1])
                    palindromeTrueCounter++;
            }

            // when ALL the characters increment to the palindromeTrueCounter it should be equal to the length of the sentence
            if (palindromeTrueCounter == characterArray.Length)
                return true;
            else
                return false;
        }

        public static string PigLatinate(string str)
        {
            if (str.Contains('a'))
                return str + "has an a and ay";
            else
                return str + "ay";
        }
    }
}
