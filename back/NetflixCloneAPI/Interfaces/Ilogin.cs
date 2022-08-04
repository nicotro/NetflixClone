namespace NetflixCloneAPI.Interfaces
{
    public class Ilogin
    {
        public interface ILogin
        {
//            public bool Login(string username, string password);
            public LoginDTO Login(UserDTO userDTO);
            public bool IsLogged();
        }

        public record UserDTO(string Username, string Password);
        public record LoginDTO(string Status,string Token, string FirstName, string Role);
    }
}
