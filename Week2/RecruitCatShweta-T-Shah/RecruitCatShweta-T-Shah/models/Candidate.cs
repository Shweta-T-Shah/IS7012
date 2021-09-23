using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatShweta_T_Shah.models
{
    public class Candidate
    {
        public int Id { get; set; }


        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Target Salary")]
        public decimal TargetSalary { get; set; }

        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [DisplayName("Notice Period (Days)")]
        public int NoticePeriodDays { get; set; }

        [DisplayName("Available Immediately(True/False)")]
        public bool? IsImmediateAvailable { get; set; }

        [DisplayName("Location Preference")]
        public string LocationPreference { get; set; }

        //[DisplayName("Minimum Salary")]
          //public decimal? MinimumSalaryRequirement { get; set; }


        [DisplayName("Email")]
        public string Email { get; set; }


        [DisplayName("DOB")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        //Company Relationship
        public Company Company { get; set; }

        [DisplayName("Company")]
        public int? CompanyId { get; set; }

        //Industry Relationship
        public Industry Industry { get; set; }

        [DisplayName("Industry")]
        public int IndustryId { get; set; }

        //JobTitle Relationship
        [DisplayName("Job Title")]
        public JobTitle JobTitle { get; set; }

        [DisplayName("Title")]
        public int JobTitleId { get; set; }

    }

}
