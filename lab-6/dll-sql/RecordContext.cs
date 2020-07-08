using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_sql
{
    public class RecordContext : DbContext
    {
        public RecordContext() : base("data source=.;Initial Catalog=records;Integrated Security=True;") { }

        public DbSet<Record> Records { get; set; }
    }
}
