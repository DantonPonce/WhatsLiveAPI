using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WhatsLiveAPI.DB;

namespace WhatsLiveAPI.Controllers.Users {
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase {
        [HttpGet]
        public IActionResult GetUsers() {
            return Ok(UserFakeDb.Users);
        }
    }
}
