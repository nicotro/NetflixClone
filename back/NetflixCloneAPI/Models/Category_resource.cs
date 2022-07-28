using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace NetflixCloneAPI.Models
{
    [Table("category_resource")]
    public class Category_resource
    {
        private int resourceId;
        private int categoryId;

        [Key]
        [Column("resource_id")]
        public int ResourceId { get => resourceId; set => resourceId = value; }

        [JsonIgnore]
        [ForeignKey("ResourceId")]
        public Resource resource { get; set; }

        [Column("category_id")]
        public int CategoryId { get => categoryId; set => categoryId = value; }

        [JsonIgnore]
        [ForeignKey("CategoryId")]
        public Category category { get; set; }

    }
}
