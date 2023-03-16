using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace DataAccessLayer.Model
{
    class Property
    {
        [Required]
        [Key]
        public int Id{get; set; }

        [Required]
        public string Address = string.Empty;
        [Required]
        public decimal Size = 0.00M;
        [Required]
        public decimal Cost = 0.00M;
        [Required]
        public decimal RegistrationCost = 0.00M;

    }
}
