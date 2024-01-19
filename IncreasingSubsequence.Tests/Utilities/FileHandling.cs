using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingSubsequence.Tests.Utilities
{
    public class FileHandling
    {
        /// <summary>
        /// Method Name:ReadFileToString
        /// Description:Reads a file and assigns it to a string.
        /// </summary>
        /// <param name="path"></param>
        /// <returns>string output</returns>
        public static string ReadFileToString(string path)
        {
            StringBuilder outputStr = new StringBuilder();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    //This allows you to do one Read operation.
                    outputStr.Append(sr.ReadToEnd());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The process failed: {0}", ex.ToString());
            }
            return outputStr.ToString();
        }
    }
}
