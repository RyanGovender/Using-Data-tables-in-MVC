using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataTable.Models
{
    public class Students
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string StudentNumber { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string ContactNumber { get; set; }
        [Required]
        public  double StudentAverage { get; set; }
    }
}