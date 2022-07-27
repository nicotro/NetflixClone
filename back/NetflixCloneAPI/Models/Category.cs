using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCloneEntity.Classes
{
    [Table("category")]
    public class Category
    {
        private int id;
        private string name;

        public Category()
        {
        }

        public int Id { get => id; set => id = value; }

        [Column("name")]
        [StringLength(maximumLength:100)]
        [Required]
        public string Name { get => name; set => name = value; }

        public virtual List<Resource> Resources { get; set; }

    }
}
