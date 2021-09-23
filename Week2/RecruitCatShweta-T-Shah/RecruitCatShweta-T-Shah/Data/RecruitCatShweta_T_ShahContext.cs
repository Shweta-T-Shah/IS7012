using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatShweta_T_Shah.models;

namespace RecruitCatShweta_T_Shah.Data
{
    public class RecruitCatShweta_T_ShahContext : DbContext
    {
        public RecruitCatShweta_T_ShahContext (DbContextOptions<RecruitCatShweta_T_ShahContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatShweta_T_Shah.models.Company> Company { get; set; }

        public DbSet<RecruitCatShweta_T_Shah.models.Candidate> Candidate { get; set; }

        public DbSet<RecruitCatShweta_T_Shah.models.Industry> Industry { get; set; }

        public DbSet<RecruitCatShweta_T_Shah.models.JobTitle> JobTitle { get; set; }
    }
}
