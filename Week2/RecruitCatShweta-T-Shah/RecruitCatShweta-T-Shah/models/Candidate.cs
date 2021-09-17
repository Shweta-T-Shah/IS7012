using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatShweta_T_Shah.models
{
    public class Candidate
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal TargetSalary { get; set; }
        public DateTime? StartDate { get; set; }
        public int NoticePeriodDays { get; set; }
        public bool? IsImmediateAvailable { get; set; }
        public string LocationPreference { get; set; }
        public decimal? MinimumSalaryRequirement { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }

        //Company Relationship
        public Company Company { get; set; }
        public int? CompanyId { get; set; }

        //Industry Relationship
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }

        //JobTitle Relationship
        public JobTitle JobTitle { get; set; }
        public int JobTitleId { get; set; }

    }

}
