using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NobelProjectAPI.Models
{
    public class NobelDBContext : DbContext
    {
        public DbSet<Prize> Prizes { get; set; }


        public NobelDBContext() : base("name=DBConnection")
        {
           //Database.SetInitializer<NobelDBContext>(new DropCreateDatabaseAlways<NobelDBContext>());
        }
    }
}