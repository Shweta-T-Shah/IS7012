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
        public string Title { get; set; }


        [DisplayName("Minimum Salary")]
        public decimal MinimumSalary { get; set; }

        [DisplayName("Maximum Salary")]
        public decimal MaximumSalary { get; set; }

        [DisplayName("Start Date")]
        public DateTime? StartDate { get; set; }

        public string Location { get; set; }
        public string Skills { get; set; }

        [DisplayName("Weekly Hours")]
        public int WeeklyHours { get; set; }


        [DisplayName("Yearly Vacation")]
        public int YearlyVacation { get; set; }

        [DisplayName("Is Critical")]
        public bool? IsCritical { get; set; }


        //Candidate Relationship
        public List<Candidate> Candidates { get; set; }

        //Company Relationship
        public List<Company> Companies { get; set; }

    }

}
