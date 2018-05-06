using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Survey
    {
        public Survey()
        {
            Questions = new List<Question>();
            Clients = new List<Client>();
        }

        public int Id { get; set; }
        public User Creator { get; set; }
        public DateTime CreationDate { get; set; }
        public ICollection<Question> Questions { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}
