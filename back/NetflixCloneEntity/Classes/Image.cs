using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCloneEntity.Classes
{
    [Table("image")]
    public class Image
    {
        private int id;
        private int resource_id;
        private int sizeType;
        private string url;

        public Image()
        {
        }

        public int Id { get => id; set => id = value; }

        [Column("resource_id")]
        [Required]
        public int Resource_id { get => resource_id; set => resource_id = value; }

        [Column("size_type")]
        [Required]
        public int SizeType { get => sizeType; set => sizeType = value; }

        [Column("url")]
        [StringLength(maximumLength: 255)]
        [Required]
        public string Url { get => url; set => url = value; }
    }
}
