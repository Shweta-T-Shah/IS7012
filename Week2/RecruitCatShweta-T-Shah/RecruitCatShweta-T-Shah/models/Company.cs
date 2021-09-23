using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace RecruitCatShweta_T_Shah.models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DisplayName("Position Name")]
        public string PositionName { get; set; }

        [DisplayName("Minimum Salary")]
        public decimal MinimumSalary { get; set; }

        [DisplayName("Maximum Salary")]
        public decimal MaximumSalary { get; set; }

        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }
        public string Location { get; set; }

        [DisplayName("CEO Name")]
        public string CEOName { get; set; }

        [DisplayName("Number Of Offices")]
        public int NumberOfOffices { get; set; }


        [DisplayName("Number Of Employees")]
        public int NumberOfEmployees { get; set; }
 
        //Candidate Relationship
        public List<Candidate> Candidates { get; set; }

        //Industry Relationship
        public Industry Industry { get; set; }

        [DisplayName("Industry")]
        public int IndustryId { get; set; }

        //JobTitle Relationship

        [DisplayName("Title")]
        public JobTitle JobTitle { get; set; }

        [DisplayName("Job Title")]
        public int JobTitleId { get; set; }

    }
}
