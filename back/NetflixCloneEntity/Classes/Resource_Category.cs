using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCloneEntity.Classes
{
    [Table("resource_category")]
    public class Resource_Category
    {
        private int id;
        private Category category;
        private int resourceId;
        private int categoryId;

        public Resource_Category()
        {
        }

        public int Id { get => id; set => id = value; }

        [ForeignKey("ResourceId")]
        public int ResourceId { get => resourceId; set => resourceId = value; }
        public Resource resource { get => resource; set => resource = value; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get => categoryId; set => categoryId = value; }
        public Category Category { get => category; set => category = value; }
    }
}
