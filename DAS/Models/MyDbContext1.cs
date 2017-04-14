using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DAS.Models
{
    // A class to expose data entities and to create the database if one does not exist
    public class MyDbContext1 : DbContext
    {
        public MyDbContext1() : base("DocumentSysAppDatabase")
        {

        }
        public DbSet<DocumentModels1> documents { get; set; }
    }
}