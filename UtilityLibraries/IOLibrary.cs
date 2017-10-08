using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace UtilityLibraries
{
    /// <summary>
    /// Static class that offers universal functions with Directories, files, writing files...etc. For .NET Standard Platform (Continuous updating class)
    /// </summary>
    public static class IOLibrary
    {
        /// <summary>
        /// Function that gets the total size of the directory in the digital unit passed as parameter</summary>
        /// <param name="directory">Directory to get the total size</param>
        /// <returns></returns>
        public static long GetDirectorySize(DirectoryInfo directory)
        {
            long bytes = 0;
            IEnumerable<FileInfo> files;
            IEnumerable<DirectoryInfo> directories;

            files = directory.GetFiles();
            directories = directory.GetDirectories();

            foreach (FileInfo xfile in files)
            {
                bytes += xfile.Length;
            }

            foreach (DirectoryInfo xdirectory in directories)
            {
                bytes += GetDirectorySize(xdirectory);
            }

            return bytes;
        }
    }
}
