using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace time_stacc_alpha_0_02.Pages.Shared
{
    [Authorize]
    public class TimerModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
