using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCloneEntity.Classes
{
    public class Faq
    {
        private int id;
        private string question;
        private string answer;

        public Faq()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Question { get => question; set => question = value; }
        public string Answer { get => answer; set => answer = value; }
    }
}
