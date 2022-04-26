using Microsoft.EntityFrameworkCore;
using Project6.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project6.Model
{
    public class Account 
    {

        public int Id { get; set; }
        public string Login { get; set; } 
        public string Password { get; set; }
        public int CountryId { get; set; }
        public DateTime LastLogin { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<AccountBoat> AccountBoats { get; set; }
    }
}
