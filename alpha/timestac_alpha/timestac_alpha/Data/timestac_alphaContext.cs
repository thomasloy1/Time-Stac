using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using timestac_alpha.Models;

namespace timestac_alpha.Data
{
    public class timestac_alphaContext : DbContext
    {
        public timestac_alphaContext (DbContextOptions<timestac_alphaContext> options)
            : base(options)
        {
        }

        public DbSet<timestac_alpha.Models.User> User { get; set; }
    }
}
