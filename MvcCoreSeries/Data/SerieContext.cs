using Microsoft.EntityFrameworkCore;
using MvcCoreSeries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreSeries.Data
{
    public class SerieContext:DbContext
    {
        public SerieContext
            (DbContextOptions<SerieContext> options)
            : base(options) { }
        public DbSet<Serie> Series { get; set; }
    }
}
