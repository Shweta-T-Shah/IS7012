﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatShweta_T_Shah.Data;
using RecruitCatShweta_T_Shah.models;

namespace RecruitCatShweta_T_Shah.Pages.JobTitles
{
    public class DeleteModel : PageModel
    {
        private readonly RecruitCatShweta_T_Shah.Data.RecruitCatShweta_T_ShahContext _context;

        public DeleteModel(RecruitCatShweta_T_Shah.Data.RecruitCatShweta_T_ShahContext context)
        {
            _context = context;
        }

        [BindProperty]
        public JobTitle JobTitle { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            JobTitle = await _context.JobTitle.FirstOrDefaultAsync(m => m.Id == id);

            if (JobTitle == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            JobTitle = await _context.JobTitle.FindAsync(id);

            if (JobTitle != null)
            {
                _context.JobTitle.Remove(JobTitle);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}