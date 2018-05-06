using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Question
    {
        public Question()
        {
            Surveys = new List<Survey> { };
            CreationDate = DateTime.Today;
        }
        public int Id { get; set; }
        public User Creator { get; set; }
        public DateTime CreationDate { get; set; }
        public string QuestionText { get; set; }
        public ICollection<Survey> Surveys { get; set; }
    }
}
