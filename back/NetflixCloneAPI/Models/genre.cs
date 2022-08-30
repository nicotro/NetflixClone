using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NetflixCloneAPI.Models
{
    [Table("genre")]
    public class Genre
    {
        private int id;
        private string name;

        public Genre()
        {
        }

        public int Id { get => id; set => id = value; }

        [Column("name")]
        [StringLength(maximumLength:100)]
        [Required]
        public string Name { get => name; set => name = value; }

        [JsonIgnore]
        public virtual List<Genre_resource> Genre_Resources { get; set; }

    }
}
