using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace lab_7a.Models
{
    public class RecordContext : DbContext
    {
        public RecordContext() : base("DBConnection") { }

        public DbSet<Record> Records { get; set; }
    }
}