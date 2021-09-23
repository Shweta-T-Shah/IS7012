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


        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Name { get; set; }


        [DisplayName("Position Name")]
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string PositionName { get; set; }


        [DisplayName("Minimum Salary")]
        [Required]
        [Range(0, 5000000)]
        public decimal MinimumSalary { get; set; }

        
        [DisplayName("Maximum Salary")]
        [Range(0, 5000000)]
        public decimal? MaximumSalary { get; set; }

        
        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }


        [StringLength(1000, MinimumLength = 1)]
        [Required]
        public string Location { get; set; }


        [DisplayName("CEO Name")]
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string CEOName { get; set; }


        [DisplayName("Number Of Offices")]
        [Range(0, 9999999999999999999)]
        public int NumberOfOffices { get; set; }


        [DisplayName("Number Of Employees")]
        [Range(0, 9999999999999999999)]
        public int NumberOfEmployees { get; set; }
 

        //Candidate Relationship
        public List<Candidate> Candidates { get; set; }


        //Industry Relationship
        [Required]
        public Industry Industry { get; set; }


        [DisplayName("Industry")]
        [Required]
        public int IndustryId { get; set; }

        //JobTitle Relationship

        [DisplayName("Title")]
        [Required]
        public JobTitle JobTitle { get; set; }

        
        [DisplayName("Job Title")]
        [Required]
        public int JobTitleId { get; set; }

    }
}
