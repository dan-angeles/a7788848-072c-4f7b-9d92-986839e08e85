using Microsoft.AspNetCore.Mvc;
using IncreasingSubsequence.Data.Models;
using IncreasingSubsequence.Data.Services;
using IncreasingSubsequence.Data.Utilities;
using System.Text.Json;
using Trips.Controllers;
using System.Text;

namespace IncreasingSubsequence.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IncreasingSubsequenceController : ControllerBase
    {
        private readonly ILogger<IncreasingSubsequenceController> _logger;

        private ISequenceService _service;
        public IncreasingSubsequenceController(ILogger<IncreasingSubsequenceController> logger,ISequenceService service)
        {
            this._logger = logger;
            this._service = service;
        }

        /// <summary>
        /// Method Name:GetLongestSequence
        /// Description:Gets the longest increasing subsequence of numbers
        /// </summary>
        /// <param name="inpSeq"></param>
        /// <returns>longest sequence of numbers</returns>
        [HttpGet("GetLongestSequence")]
        public IActionResult GetLongestSequence([FromBody] InputSequence inpSeq)
        {
            StringBuilder jsonString = new StringBuilder();
            try
            {
                jsonString.Append(
                    JsonSerializer.Serialize(
                        _service.GetLongestIncNumSeq(
                            StringTools.SplitStringToList(inpSeq.SequenceOfNumbers," ")
                            )
                        )
                    );
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
            return Ok(jsonString.ToString());
        }
        
    }
}
