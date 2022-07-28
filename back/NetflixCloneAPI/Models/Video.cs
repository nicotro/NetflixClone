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
    [Table("video")]
    public class Video
    {
        private string id;
        private string text;
        private string uri;

        private int resourceId;

        public Video()
        {
        }

        public string Id { get => id; set => id = value; }

        [Column("text")]
        [Required]
        public string Text { get => text; set => text = value; }

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
