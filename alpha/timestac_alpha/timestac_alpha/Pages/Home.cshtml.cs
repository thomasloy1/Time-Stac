using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace timestac_alpha.Pages.Shared
{
    public class HomeModel : PageModel
    {
        private readonly timestac_alpha.Data.timestac_alphaContext _context;

        public HomeModel(timestac_alpha.Data.timestac_alphaContext context)
        {
            _context = context;
        }
    }
}
