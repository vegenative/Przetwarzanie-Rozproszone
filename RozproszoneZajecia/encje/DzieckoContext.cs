using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RozproszoneZajecia.encje
{
    public class DzieckoContext: DbContext
    {
		private string polaczenie = "Server=(localdb)\\mssqllocaldb;database=Dziecko;Trusted_Connection=True;";
		public DbSet<Dziecko> dzieci { get; set; }
		public DbSet<Zestaw> zestawy { get; set; }
		public DbSet<Klocek> klocki { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Dziecko>()
				.HasOne(Dziecko => Dziecko.zestawy)
				.WithOne(Zestaw => Zestaw.dzieci)
				.HasForeignKey<Zestaw>(zestaw => zestaw.dzieciId);

			modelBuilder.Entity<Zestaw>()
				.HasMany(Zestaw => Zestaw.klocki)
				.WithOne(Klocek => Klocek.zestawy)
				.HasForeignKey(Klocek => Klocek.zestawId);
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(polaczenie);
		}
	}
}
