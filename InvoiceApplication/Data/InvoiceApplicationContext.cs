using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InvoiceApplication.Models;

namespace InvoiceApplication.Data
{
    public class InvoiceApplicationContext : DbContext
    {
        public InvoiceApplicationContext (DbContextOptions<InvoiceApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<InvoiceApplication.Models.AddDetails> AddDetails { get; set; } = default!;
        public DbSet<InvoiceApplication.Models.InvoiceForm> InvoiceForm { get; set; } = default!;
    }
}
