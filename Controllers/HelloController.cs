using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CreationWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        public string[] myData = { "Data1", "Data2", "Data3" };
        [HttpGet]
        public string[] getData()
        {
            return myData;
        }
    }
}
