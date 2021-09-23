using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace RecruitCatShweta_T_Shah.models
{
    public class Industry
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Name { get; set; }


        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Domain { get; set; }


        [DisplayName("Number Of Company")]
        [Required]
        [Range(0, 99999999999)]
        public int NumberOfCompany { get; set; }


        [DisplayName("Number Of Candidate")]
        [Required]
        [Range(0, 99999999999)]
        public int NumberOfCandidate { get; set; }

        [Required]
        [Range(0, 9999999999999999999)]
        public decimal Revenue { get; set; }

        
        [DisplayName("High Risk")]
        [Required]
        public bool HighRisk { get; set; }

        
        [DisplayName("Pollution Rating (/10)")]
        [Range(0, 10, ErrorMessage = "Please enter a number between 1-10, 10 is highest pollution rating")]
        [Required]
        public decimal PollutionRating { get; set; }


        //Candidate Relationship
        public List<Candidate> Candidates { get; set; }


        //Company Relationship
        public List<Company> Companies { get; set; }

    }

}
