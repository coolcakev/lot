
using lotforussr.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lotforussr
{
    
        public class ApplicationContext : DbContext
        {
            public DbSet<User> Users { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Historyforlot> Historyforlots { get; set; }


        public DbSet<Historyforuser> Historyforusers { get; set; }


        public DbSet<lot> Lots { get; set; }



        public ApplicationContext(DbContextOptions<ApplicationContext> options)
                : base(options)
            {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }
    
}
