using System;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace ConsoleApplication2
{
    public class Targil2
    {
        public string replace(string txt, string substring, string replace)
        {
            string newStriong = txt.Replace(substring, replace);        //replace method in string, does not change original string. it returns a new one.

            return newStriong;
        }

        public string reverse(string s)
        {
            char[] array = s.ToCharArray();  //עכשיו הפכתי את הסטרינג למערך תווים
            Array.Reverse(array);
            string newString = new string(array); //הפכנו את המערך לסטרינג
            return newString;
        }
        
        public string removalItems(string str, char ch)
        {
            //str.Replace(oldString, newString);    //מחליף את הolostring עם newstring
            
            
            ch.
            return str.Replace(ch.ToString(),"");
        }
        
        public string getSkip(string text, int skipSize)
        {
            return text.Substring(skipSize);
        }
    }
}