using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatShweta_T_Shah.Pages
{
    public class OurTeamModel : PageModel
    {
        private readonly ILogger<OurTeamModel> _logger;

        public OurTeamModel(ILogger<OurTeamModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
