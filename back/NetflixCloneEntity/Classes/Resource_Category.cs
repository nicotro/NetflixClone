using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCloneEntity.Classes
{
    public class Resource_Category
    {
        private int id;
        private string resource_id;
        private string category_id;

        public int Id { get => id; set => id = value; }
        public string Resource_id { get => resource_id; set => resource_id = value; }
        public string Category_id { get => category_id; set => category_id = value; }
    }
}
