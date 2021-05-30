using Microsoft.EntityFrameworkCore;
using SWM_APP.Models.DdContext.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWM_APP.Models.DdContext
{
    public class DatabaseContext: DbContext
    {
        public DbSet<WSREF> WSREF { get; set; }
        public DbSet<WSREFCOMMENT> WSREFComment { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }
    }
}
