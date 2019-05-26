using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp5.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Text value with max 50 characters")]
        public string Name { get; set; }
    }
}
