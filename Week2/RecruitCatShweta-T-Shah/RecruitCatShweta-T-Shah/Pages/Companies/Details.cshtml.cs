using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatShweta_T_Shah.Data;
using RecruitCatShweta_T_Shah.models;

namespace RecruitCatShweta_T_Shah.Pages.Companies
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatShweta_T_Shah.Data.RecruitCatShweta_T_ShahContext _context;

        public DetailsModel(RecruitCatShweta_T_Shah.Data.RecruitCatShweta_T_ShahContext context)
        {
            _context = context;
        }

        public Company Company { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id) 
        {
            if (id == null)
            {
                return NotFound();
            }

            Company = await _context.Company.Include(x => x.Candidates).FirstOrDefaultAsync(m => m.Id == id);


            if (Company == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
