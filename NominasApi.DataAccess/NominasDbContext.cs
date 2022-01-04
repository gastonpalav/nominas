using Microsoft.EntityFrameworkCore;
using NominasApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominasApi.DataAccess
{
    public class NominasDbContext : DbContext
    {
        public DbSet<Alumno> Alumnos { get; set; }

        public NominasDbContext(DbContextOptions<NominasDbContext> options) 
            :base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<EntityBase>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
