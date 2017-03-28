using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DAS.Models
{
    public class MyDbContext1 : DbContext
    {
        public MyDbContext1() : base("DocumentSysAppDatabase")
        {

        }
        public DbSet<DocumentModels1> documents { get; set; }
    }
}