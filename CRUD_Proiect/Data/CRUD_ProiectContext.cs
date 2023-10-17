using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD_Proiect.Test;

namespace CRUD_Proiect.Data
{
    public class CRUD_ProiectContext : DbContext
    {
        public CRUD_ProiectContext (DbContextOptions<CRUD_ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<CRUD_Proiect.Test.Utilizator> Utilizator { get; set; } = default!;
    }
}
