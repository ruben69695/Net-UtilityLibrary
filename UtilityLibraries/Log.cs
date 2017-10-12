using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace UtilityLibraries
{
    class Log
    {
        private string filename = "";

        public Log(string xfilename)
        {
            this.filename = xfilename;
        }

        public async void AddLog(string text)
        {
            if (!(String.IsNullOrWhiteSpace(text)))
            {
                UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
                byte[] result = unicodeEncoding.GetBytes(String.Format("{0} - ", DateTime.Now, text));

                using (FileStream SourceStream = File.Open(this.filename, FileMode.Append))
                {
                    await SourceStream.WriteAsync(result, 0, result.Length);
                }
            }
        }

        public void SetFilename(string xfilename)
        {
            this.filename = xfilename;
        }

    }
}
