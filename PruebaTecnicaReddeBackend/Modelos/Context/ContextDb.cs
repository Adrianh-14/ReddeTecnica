using Microsoft.EntityFrameworkCore;
using Modelos.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos.Context
{
    public class ContextDb : DbContext
    {
        public DbSet<Empresas> Empresas { get; set; }

        public ContextDb(DbContextOptions<ContextDb> obj) : base(obj)
        {
            
        }

    }
}
