using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCloneEntity.Classes
{
    [Table("video")]
    public class Video
    {
        private string id;
        //private int resource_id;
        private string text;
        private string url;

        public Video()
        {
        }

        public string Id { get => id; set => id = value; }

        //[Column("resource_id")]
        //[Required]
        //public int Resource_id { get => resource_id; set => resource_id = value; }

        [Column("text")]
        [Required]
        public string Text { get => text; set => text = value; }

        [Column("url")]
        [StringLength(maximumLength: 255)]
        [Required]
        public string Url { get => url; set => url = value; }
    }
}
