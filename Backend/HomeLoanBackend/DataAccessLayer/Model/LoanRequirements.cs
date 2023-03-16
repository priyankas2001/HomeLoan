using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Model
{
    class LoanRequirements
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public decimal LoanAmount = 0.00M;

        [Required]
        public int LoanDuration = 0;

        [Required]
        public DateTime LoanStartDate = new DateTime(2000,08,13);

    }
}
