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
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string FirstName { get; set; }
        

        [DisplayName("Last Name")]
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string LastName { get; set; }


        [DisplayName("Target Salary")]
        [Required]
        [Range(0,5000000)]
        public decimal TargetSalary { get; set; }


        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }


        [DisplayName("Notice Period (Days)")]
        [Range(0, 360)]
        public int NoticePeriodDays { get; set; }


        [DisplayName("Available Immediately(True/False)")]
        public bool? IsImmediateAvailable { get; set; }


        [DisplayName("Location Preference")]
        public string LocationPreference { get; set; }

         
        [DisplayName("Email")]
        [Required]
        [StringLength(1000, MinimumLength = 1, ErrorMessage = "Please enter a valid email address")]
        [RegularExpression("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$" , ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }


        [DisplayName("DOB")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }


        [StringLength(100, MinimumLength = 1)]
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
