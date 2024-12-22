using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CookBookWebSQL.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        [Required]
        public string Topic { get; set; }
        [Required]
        public string Description { get; set;}
    }
}