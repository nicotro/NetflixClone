using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCloneEntity.Classes
{
    [Table("user")]
    public class User
    {

        private int id;
        private string firstName;
        private string lastName;
        private string email;
        private string password;
        private Role role;
        private bool banned;

        public User()
        {
            Banned = false;
        }

        public int Id { get => id; set => id = value; }

        [Column("first_name")]
        [StringLength(maximumLength: 255)]
        [Required]
        public string FirstName { get => firstName; set => firstName = value; }

        [Column("last_name")]
        [StringLength(maximumLength: 255)]
        [Required]
        public string LastName { get => lastName; set => lastName = value; }

        [Column("email")]
        [StringLength(maximumLength: 100)]
        [Required]
        public string Email { get => email; set => email = value; }

        [Column("password")]
        [StringLength(maximumLength: 255)]
        [Required]
        public string Password { get => password; set => password = value; }

        [ForeignKey("roleId")]
        public Role Role { get => role; set => role = value; }
        public int RoleId { get; set; }
        
        [Column("banned_user")]
        public bool Banned { get => banned; set => banned = value; }
    }
}
