using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using static NetflixCloneAPI.Interfaces.Ilogin;

namespace NetflixCloneAPI.Controllers
{
    [Route("api/v1/user")]
    [ApiController]
    [EnableCors("AllowAll")]

    public class UserControllerAPI : ControllerBase
    {
        private ILogin _loginService;
        public UserControllerAPI(ILogin loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        public IActionResult Post(UserDTO userDTO)
        {
            string token = _loginService.Login(userDTO);
            if (token != null)
            {
                return Ok(new { token,User });
            }
            else
            {
                return StatusCode(401);
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("test Get admin");
        }
    }
}
