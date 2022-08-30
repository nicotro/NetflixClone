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

        [Route("signin")]
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

        [Route("signup")]
        [HttpPost]
        public IActionResult Post(NewUserDTO newUserDTO)
        {
            string createNewUser = _loginService.Register(newUserDTO);
            if (createNewUser ==null)
            {
                return Ok($"Account successfully created, welcome {newUserDTO.FirstName}!");
            }
            else
            {
                return BadRequest(createNewUser);
            }
        }

        [Route("signedin")]
        [HttpGet]
        [Authorize("users")]
        public IActionResult Check()
        {
            return Ok();
        }

        [HttpGet]
        [Authorize("admin")]
        public IActionResult Get()
        {
            return Ok("test Get admin");
        }
    }
}
