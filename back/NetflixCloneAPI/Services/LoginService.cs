using Microsoft.IdentityModel.Tokens;
using NetflixCloneAPI.Models;
using NetflixCloneAPI.Repositories;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using static NetflixCloneAPI.Interfaces.Ilogin;

namespace NetflixCloneAPI.Services
{
    public class LoginService:ILogin
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

        public string Login(UserDTO userDTO)
        {
            User u = _userRepository.Find(u => u.Email == userDTO.Username && u.Password == userDTO.Password);
            if (u != null)
            {
                return CreateToken(u);
            }
            return null;
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
