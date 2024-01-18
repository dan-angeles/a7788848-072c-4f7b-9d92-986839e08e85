using Microsoft.AspNetCore.Mvc;

namespace IncreasingSubsequence.Controllers
{
        [ApiController]
        [Route("[controller]")]
    public class IncreasingSubsequenceController : ControllerBase
    {   
        public static void abc(string x)
        {
            List<string> xyz = x.Split(' ').ToList<string>();
        }
        
    }
}
