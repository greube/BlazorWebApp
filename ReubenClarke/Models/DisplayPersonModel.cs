using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReubenClarke.Models
{
    public class DisplayPersonModel
    {
        [Required]
        [StringLength(50,ErrorMessage = "Name can't exceed 50 characters")]
        public string Firstname { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Name can't exceed 50 characters")]
        public string LastName { get; set; }

    }
}
