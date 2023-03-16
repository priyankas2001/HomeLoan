using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccessLayer.Model
{
    internal class Application
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [ForeignKey (nameof(UserId))]
        [Required]
        public int UserId { get; set; }
        [ForeignKey(nameof(PropertyId))]
        [Required]
        public int PropertyId { get; set; }
        [ForeignKey(nameof(PersonalIncomeId))]
        [Required]
        public int PersonalIncomeId { get; set; }
        [ForeignKey(nameof(LoanRequirementId))]
        [Required]
        public int LoanRequirementId { get; set; }

    }
}
