using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCloneEntity.Classes
{
    [Table("role")]
    public class Role
    {
        private int id;
        private string function;

        public Role()
        {
        }

        public int Id { get => id; set => id = value; }

        [Column("function")]
        [StringLength(maximumLength:100)]
        [Required]
        public string Function { get => function; set => function = value; }
    }
}
