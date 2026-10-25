using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAssimentNumber1.Models
{
    public class Author
    {

        public string  First_Name { get; set; }

        public string Last_Name { get; set; }

        [Key]
        public string Email_Address { get; set; }

        public DateTime DBO { get; set; }

        public string Bigrofy { get; set; }
    }
}
