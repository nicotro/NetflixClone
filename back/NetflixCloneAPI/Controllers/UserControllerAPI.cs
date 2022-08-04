using Microsoft.AspNetCore.Authorization;
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
            LoginDTO login = _loginService.Login(userDTO);
            if (login.Status == "OK")
            {
                return Ok(login);
            }
            else
            {
                return BadRequest(login.Status);
            }
        }

        [HttpGet]
        [Authorize("admin")]
        public IActionResult Get()
        {
            return Ok("test Get admin");
        }
    }
}
