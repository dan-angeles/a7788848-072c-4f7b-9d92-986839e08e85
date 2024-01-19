namespace IncreasingSubsequence.Data.Utilities
{
    public class StringTools
    {
        /// <summary>
        /// Method Name: SplitStringToList
        /// Description: Splits a String by a separator
        /// </summary>
        /// <param name="inputStr"></param>
        /// <param name="separator"></param>
        /// <returns>returns a list of string</returns>
        public static List<string> SplitStringToList(string inputStr,string separator)
        {
            return inputStr.Trim().Split(separator).ToList<string>();
        }
    }
}
