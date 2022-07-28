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
    [Table("image")]
    public class Image
    {
        private int id;
        private int sizeType;
        private string uri;

        private int resourceId;

        public Image()
        {
        }

        public int Id { get => id; set => id = value; }

        [Column("size_type")]
        [Required]
        public int SizeType { get => sizeType; set => sizeType = value; }

        [Column("uri")]
        [StringLength(maximumLength: 255)]
        [Required]
        public string Uri { get => uri; set => uri = value; }

        [Column("resource_id")]
        public int ResourceId { get => resourceId; set => resourceId = value; }

        [JsonIgnore]
        [ForeignKey("ResourceId")]
        public Resource resource { get; set; }
    }
}
