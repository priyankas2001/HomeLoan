using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessLayer.Model
{
    internal class User
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string EmailId = string.Empty;
        [Required]
        public string Password = string.Empty;
        [Required]
        public string MobileNumber = string.Empty;
        [Required]
        public string CityCode = string.Empty;
        [Required]
        public string StateCode = string.Empty;
        [Required]
        public string CountryCode = string.Empty;

    }
}
