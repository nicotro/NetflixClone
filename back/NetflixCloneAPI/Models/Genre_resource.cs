using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace NetflixCloneAPI.Models
{
    [Table("genre_resource")]
    public class Genre_resource
    {
        private int resourceId;
        private int genreId;

        [Key]
        [Column("resource_id")]
        public int ResourceId { get => resourceId; set => resourceId = value; }

        [JsonIgnore]
        [ForeignKey("ResourceId")]
        public Resource resource { get; set; }

        [Column("genre_id")]
        public int GenreId { get => genreId; set => genreId = value; }

        [JsonIgnore]
        [ForeignKey("GenreId")]
        public Genre genre { get; set; }

    }
}
