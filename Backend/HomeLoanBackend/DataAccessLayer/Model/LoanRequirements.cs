using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Model
{
    public class LoanRequirements
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public double LoanAmount { get; set; }

        [Required]
        public int LoanDuration { get; set; }

        [Required]
        public DateTime LoanStartDate { get; set; }

    }
}
