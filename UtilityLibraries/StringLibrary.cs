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
    }
}
