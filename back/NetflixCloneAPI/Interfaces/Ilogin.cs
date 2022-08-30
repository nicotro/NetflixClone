namespace NetflixCloneAPI.Interfaces
{
    public class Ilogin
    {
        public interface ILogin
        {
            public string Register(NewUserDTO newUserDTO);
            public LoginDTO Login(UserDTO userDTO);
            public bool IsLogged();
        }

        public record UserDTO(string Username, string Password);
        public record NewUserDTO(string FirstName, string LastName, string Email, string Phone, string Password);
        public record LoginDTO(string Status, string Token, string FirstName, string Role);
    }
}
