using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatShweta_T_Shah.models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PositionName { get; set; }
        public decimal MinimumSalary { get; set; }
        public decimal MaximumSalary { get; set; }
        public DateTime? StartDate { get; set; }
        public string Location { get; set; }
        public string CEOName { get; set; }
        public int NumberOfOffices { get; set; }
        public int NumberOfEmployees { get; set; }
 
        //Candidate Relationship
        public List<Candidate> Candidates { get; set; }

        //Industry Relationship
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }

        //JobTitle Relationship
        public JobTitle JobTitle { get; set; }
        public int JobTitleId { get; set; }

    }
}
