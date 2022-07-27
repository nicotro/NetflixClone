using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCloneEntity.Classes
{
    [Table("Faq")]
    public class Faq
    {
        private int id;
        private string question;
        private string answer;

        public Faq()
        {
        }

        public int Id { get => id; set => id = value; }

        [Column("question")]
        [Required]
        public string Question { get => question; set => question = value; }

        [Column("answer")]
        [Required]
        public string Answer { get => answer; set => answer = value; }
    }
}
