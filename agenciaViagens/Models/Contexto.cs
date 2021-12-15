using System;
using Microsoft.EntityFrameworkCore;

namespace agenciaViagens.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<origem> origem { get; set; }
    }
}