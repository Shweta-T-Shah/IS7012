using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatShweta_T_Shah.models
{
    public class Industry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Domain { get; set; }
        public int NumberOfCompany { get; set; }
        public int NumberOfCandidate { get; set; }
        public decimal Revenue { get; set; }
        public bool? HighRisk { get; set; }
        public decimal PollutionRating { get; set; }


        //Candidate Relationship
        public List<Candidate> Candidates { get; set; }


        //Company Relationship
        public List<Company> Companies { get; set; }

    }

}
