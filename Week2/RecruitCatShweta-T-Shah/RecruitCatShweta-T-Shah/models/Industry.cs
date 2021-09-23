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
        public string Name { get; set; }
        public string Domain { get; set; }


        [DisplayName("Number Of Company")]
        public int NumberOfCompany { get; set; }

        [DisplayName("Number Of Candidate")]
        public int NumberOfCandidate { get; set; }
        public decimal Revenue { get; set; }


        [DisplayName("High Risk (True/False)")]
        public bool? HighRisk { get; set; }

        [DisplayName("Pollution Rating (/10)")]
        public decimal PollutionRating { get; set; }


        //Candidate Relationship
        public List<Candidate> Candidates { get; set; }


        //Company Relationship
        public List<Company> Companies { get; set; }

    }

}
