using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessLayer.Model
{
    internal class PersonalIncome
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public decimal MonthlyFamilyIncome = 0.0M;
        [Required]
        public decimal OtherIncome = 0.0M;
    }
}
