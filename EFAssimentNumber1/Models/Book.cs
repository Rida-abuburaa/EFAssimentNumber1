using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFAssimentNumber1.Models
{
    public class Book
    {
        [Key]
        public int ISBN { get; set; }
        public string title { get; set; }
        
        public int  price { get; set; }
        public int Page_number { get; set; }
        public string  year { get; set; }

    }
}
