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
        [BindProperty]
        public string time { get; set; }

        public IActionResult OnPost()
        {
            try
            {
                int[] splittime = time.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();

                if (splittime.Length > 3)
                {
                    return BadRequest();
                }

                int hours = splittime[0];
                int minutes = splittime[1];
                int seconds = splittime[2];
            }

            catch (FormatException)
            {
                return BadRequest();
            }
            catch (OverflowException) 
            {
                return new StatusCodeResult(500);
            }




            return RedirectToPage("./Timer");
        }
    }
}
