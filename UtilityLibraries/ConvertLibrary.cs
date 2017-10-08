using System;
using System.Collections.Generic;
using System.Text;

namespace UtilityLibraries
{
    /// <summary>
    /// Static class that offers universal functions with conversions for .NET Standard Platform (Continuous developing class)
    /// </summary>
    public static class Conversion
    {
        /// <summary>
        /// Function to convert bytes to megabytes
        /// </summary>
        /// <param name="bytes">Number of bytes</param>
        /// <returns>Double in megabytes</returns>
        public static Double FromBytesToMegaBytes(long bytes)
        {
            return System.Convert.ToDouble((bytes / (Math.Pow(1024, 2))));
        }
    }
}
