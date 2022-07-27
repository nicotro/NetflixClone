using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCloneEntity.Classes
{
    [Table("resource")]
    public class Resource
    {
        private int id;
        private string name;
        private string infos;
        private string season;

        public Resource()
        {
        }

        public int Id { get => id; set => id = value; }

        [Column("name")]
        [StringLength(maximumLength: 255)]
        [Required]
        public string Name { get => name; set => name = value; }

        [Column("infos")]
        [Required]
        public string Infos { get => infos; set => infos = value; }

        [Column("season")]
        [StringLength(maximumLength: 100)]
        [Required]
        public string Season { get => season; set => season = value; }

        public virtual List<Category> Categories { get; set; }
        public virtual List<Image> Images { get; set; }
        public virtual List<Video> Videos { get; set; }
    }
}
