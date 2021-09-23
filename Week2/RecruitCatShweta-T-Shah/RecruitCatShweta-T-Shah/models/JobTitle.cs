using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatShweta_T_Shah.models
{

    public class JobTitle
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Title { get; set; }


        [DisplayName("Minimum Salary")]
        [Required]
        [Range(0, 5000000)]
        public decimal MinimumSalary { get; set; }


        [DisplayName("Maximum Salary")]
        [Required]
        [Range(0, 5000000)]
        public decimal MaximumSalary { get; set; }

        
        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }


        [StringLength(100, MinimumLength = 1)]
        public string Location { get; set; }


        [StringLength(1000, MinimumLength = 1)]
        public string Skills { get; set; }


        [DisplayName("Weekly Hours")]
        [Required]
        [Range(0, 72)]
        public int WeeklyHours { get; set; }


        [DisplayName("Yearly Vacation")]
        [Required]
        [Range(0, 365)]
        public int YearlyVacation { get; set; }

        
        [DisplayName("Is Critical (True/False)")]
        public bool? IsCritical { get; set; }


        //Candidate Relationship
        public List<Candidate> Candidates { get; set; }

        //Company Relationship
        public List<Company> Companies { get; set; }

    }

}
