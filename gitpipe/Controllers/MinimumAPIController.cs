using Microsoft.AspNetCore.Mvc;

namespace gitpipe.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class MinimumAPIController
    {
        [HttpGet]
        public bool Load()
        {
            return true;
        }
    }
}
