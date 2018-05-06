using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Client
    {
        public Client()
        {
            Surveys = new List<Survey> { };
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ZipCode { get; set; }
        public ICollection<Survey> Surveys { get; set; }
        public User Owner { get; set; }
    }
}
