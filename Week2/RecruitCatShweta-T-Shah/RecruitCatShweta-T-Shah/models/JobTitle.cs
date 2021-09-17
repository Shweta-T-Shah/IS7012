using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatShweta_T_Shah.models
{

    public class JobTitle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal MinimumSalary { get; set; }
        public decimal MaximumSalary { get; set; }
        public DateTime? StartDate { get; set; }
        public string Location { get; set; }
        public string Skills { get; set; }
        public int WeeklyHours { get; set; }
        public int YearlyVacation { get; set; }
        public bool? IsCritical { get; set; }


        //Candidate Relationship
        public List<Candidate> Candidates { get; set; }

        //Company Relationship
        public List<Company> Companies { get; set; }

    }

}
