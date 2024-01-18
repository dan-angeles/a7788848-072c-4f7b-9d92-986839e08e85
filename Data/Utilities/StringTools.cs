namespace IncreasingSubsequence.Data.Utilities
{
    public class StringTools
    {
        public static List<string> SplitStringToList(string inputStr)
        {
            return inputStr.Trim().Split(' ').ToList<string>();
        }
    }
}
