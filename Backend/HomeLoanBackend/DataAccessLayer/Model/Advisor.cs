using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessLayer.Model
{
    internal class Advisor
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string EmailId = string.Empty;

        [Required]
        public string Password = string.Empty;
    }
}
