using System;

namespace UtilityLibraries
{
    /// <summary>
    /// Static class that offers universal functions with numbers for .NET Standard Platform (Continuous updating class)
    /// </summary>
    public static class NumberLibrary
    {
        /// <summary>
        /// Get a random number between a min and max number
        /// </summary>
        /// <param name="min">Min number</param>
        /// <param name="max">Max number, needs to be greater than min number</param>
        /// <returns>int</returns>
        public static int GetRandom(int min, int max)
        {
            Random random = new Random();
            return (random.Next(min, max));
        }
    }
}
