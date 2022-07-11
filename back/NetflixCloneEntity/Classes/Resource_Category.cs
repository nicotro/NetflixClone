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
        private string resourceId;
        private string categoryId;

        public Resource_Category()
        {
        }

        public int Id { get => id; set => id = value; }

        [ForeignKey("ResourceId")]
        public Resource resource { get => resource; set => resource = value; }
        public string ResourceId { get => resourceId; set => resourceId = value; }

        [ForeignKey("CategoryId")]
        public Category category { get => category; set => category = value; }
        public string CategoryId { get => categoryId; set => categoryId = value; }
    }
}
