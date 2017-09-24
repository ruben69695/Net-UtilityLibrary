using System;
using System.Collections.Generic;
using System.Text;

namespace UtilityLibraries
{
    /// <summary>
    /// Static class that offers universal functions with Strings for .NET Standard Platform (Continuous updating class)
    /// </summary>
    public static class StringLibrary
    {
        /// <summary>
        /// Checks and returns true if the string starts with Upper letter
        /// </summary>
        /// <param name="str">String to check</param>
        /// <returns>bool</returns>
        public static bool StartsWithUpper(this String str)
        {
            if (String.IsNullOrWhiteSpace(str))
                return false;

            Char ch = str[0];
            return (Char.IsUpper(ch));
        }

        /// <summary>
        /// Returns a random string from a list
        /// </summary>
        /// <param name="lsWords">String list</param>
        /// <returns>String</returns>
        public static String randomWord(List<String> lsWords)
        {
            if (lsWords == null || lsWords.Count <= 0)
                return "";
            Random R = new Random();            
            return lsWords[R.Next(0, lsWords.Count - 1)];
        }



    }
}
