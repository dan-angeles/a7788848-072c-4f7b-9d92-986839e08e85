using System.Data;
using System.Numerics;
using System.Text;

namespace IncreasingSubsequence.Data.Services
{
    /// <summary>
    /// SequenceService: a service that returns sequence of numbers
    /// </summary>
    public class SequenceService:ISequenceService
    {
        /// <summary>
        /// Method Name: GetLongestIncNumSeq
        /// Description: Returns a string containing the longest increasing subsequence of integers
        /// </summary>
        /// <param name="listOfStr"></param>
        /// <returns>string of longest increasing subsequence of integers</returns>
        public string GetLongestIncNumSeq(List<string> listOfStr)
        {
            //Declarations
            int highestSeqCnt = 1;
            int countUp = 0;
            StringBuilder sampleSeqOfNum = new StringBuilder();
            sampleSeqOfNum.Append(listOfStr[0].Trim() + " ");
            StringBuilder returnSeqOfNum = new StringBuilder();

            //Logic:Start
            for(int i = 1; i < listOfStr.Count; i++)
            {
                //get previous and current values
                int prevVal = Int32.Parse(listOfStr[i - 1].Trim());
                int currVal=  Int32.Parse(listOfStr[i].Trim());
            
                if (prevVal <= currVal)
                {
                    countUp++;
                    sampleSeqOfNum.Append(currVal + " ");
                    if (countUp > highestSeqCnt)
                    {
                        //this ensures that only the longest increasing subsequence will be recorded
                        highestSeqCnt = countUp;
                        returnSeqOfNum.Clear();
                        returnSeqOfNum.Append(sampleSeqOfNum.ToString().Trim());
                    }
                }
                else
                {    
                    //counting and parsing is restarted 
                    sampleSeqOfNum.Clear();
                    sampleSeqOfNum.Append(currVal + " ");
                    countUp = 1;
                }
            }
            //Logic:End
            return returnSeqOfNum.ToString();
        }
    }
}
