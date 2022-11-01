using CompositeNumbersApi.Classes;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CompositeNumbersApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompositeNumbersController : ControllerBase
    {
        // GET number
        [HttpGet("GetCheckSingleCompositeNumber")]
        public bool CheckSingleCompositeNumber(int number)
        {
            return new CompositeNumbers().CheckSingleCompositeNumber(number);
        }
        // GET composite numbers  list
        [HttpGet("CheckMultipleCompositeNumbers")]
        public List<long> CheckMultipleCompositeNumbers(int n1, int n2)
        {
            return new CompositeNumbers().CheckMultipleCompositeNumbers(n1, n2);
        }
    }
}