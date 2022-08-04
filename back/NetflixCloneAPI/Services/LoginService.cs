using Microsoft.IdentityModel.Tokens;
using NetflixCloneAPI.Models;
using NetflixCloneAPI.Repositories;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using static NetflixCloneAPI.Interfaces.Ilogin;

namespace NetflixCloneAPI.Services
{
    public class LoginService : ILogin
    {
        private BaseRepository<User> _userRepository;
        public LoginService(BaseRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public bool IsLogged()
        {
            throw new NotImplementedException();
        }

        /*        public bool Login(string username, string password)
                {
                    throw new NotImplementedException();
                }*/

        public LoginDTO Login(UserDTO userDTO)
        {
            string message = "User unknown";
            string token = null;
            string firstname = null;
            string role = null;

            User u = _userRepository.Find(u => u.Email == userDTO.Username);
            if (u != null)
            {
                if (u.Password == userDTO.Password)
                {
                    message = "OK";
                    token = CreateToken(u);
                    firstname = u.FirstName;
                    role = u.Role.Function;
                }
                else
                {
                    message = "Invalid password";
                }
            }
            return new LoginDTO(message, token, firstname, role);

        }

        private string CreateToken(User user)
        {
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            SecurityTokenDescriptor securityTokenDescriptor = new SecurityTokenDescriptor()
            {
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes("This is the NetflixClone JWT token encoding string")), SecurityAlgorithms.HmacSha256Signature),
                Issuer = "NetflixClone",
                Audience = "NetflixClone",
                Subject = new ClaimsIdentity(new Claim[]
                {
                        new Claim("role", user.Role.Function),
                        new Claim("username", user.Email)
                })
            };

            SecurityToken token = tokenHandler.CreateToken(securityTokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
