using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatShweta_T_Shah.Data;
using RecruitCatShweta_T_Shah.models;

namespace RecruitCatShweta_T_Shah.Pages.Industries
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatShweta_T_Shah.Data.RecruitCatShweta_T_ShahContext _context;

        public IndexModel(RecruitCatShweta_T_Shah.Data.RecruitCatShweta_T_ShahContext context)
        {
            _context = context;
        }

        public IList<Industry> Industry { get;set; }

        public async Task OnGetAsync()
        {
            Industry = await _context.Industry.ToListAsync();
        }
    }
}
