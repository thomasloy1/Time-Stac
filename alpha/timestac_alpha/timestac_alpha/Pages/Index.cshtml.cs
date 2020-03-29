using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using timestac_alpha.Data;
using timestac_alpha.Models;

namespace timestac_alpha
{
    public class IndexModel : PageModel
    {
        private readonly timestac_alpha.Data.timestac_alphaContext _context;

        public IndexModel(timestac_alpha.Data.timestac_alphaContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
