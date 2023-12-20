using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApplication.Models
{
    public class Staff
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter staff name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter staff gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please enter staff email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter staff phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please enter staff address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter staff department")]
        public string Department { get; set; }
        [Required(ErrorMessage = "Please enter staff salary")]
        public string Salary { get; set; }

    }
}
