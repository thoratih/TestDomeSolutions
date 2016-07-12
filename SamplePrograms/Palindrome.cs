using System;
using System.Linq;

namespace SamplePrograms
{
    public class Palindrome
    {
        public static bool IsPalindrome(string str)
        {
            //Check for a valid string
            if (!(string.IsNullOrEmpty(str)))
            {
                //Convert to lower character
                str = str.ToLower();

                //Remove whitespaces and other characters
                var newStr = String.Join("", str.Where(char.IsLetterOrDigit));
                
                //Add the characters to a char array
                var charArray = newStr.ToCharArray();

                //Reverse the char Array
                var reverseArray = charArray.Reverse().ToArray();

                //Compare the characters at each index

                for (int i = 0; i < charArray.Length; i++)
                {
                    if (charArray[i] != reverseArray[i])
                    {
                        return false;
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("Noel sees Leon."));
        }
    }
}
