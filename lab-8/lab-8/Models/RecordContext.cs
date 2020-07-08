using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_8.Models
{
    public class RecordContext : DbContext
    {
        public RecordContext(DbContextOptions<RecordContext> options) : base(options) { }

        public DbSet<Record> Records { get; set; }
    }
}
