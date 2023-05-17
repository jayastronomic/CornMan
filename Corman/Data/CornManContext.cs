using System;
using Microsoft.EntityFrameworkCore;
using Corman.Models;

namespace Corman.Data
{
	public class CornManContext : DbContext
	{
		public virtual DbSet<User> Users { get; set; }
		public virtual DbSet<Location> Locations{ get; set; }
		public virtual DbSet<Neighborhood> Neighborhoods { get; set; }

		public CornManContext(DbContextOptions<CornManContext> options): base(options)
		{

		}


		protected override void OnModelCreating(ModelBuilder modelBuilder) 
		{
			base.OnModelCreating(modelBuilder);
			// 1 - 1
			modelBuilder.Entity<Location>(entity => {
				entity.HasOne(u => u.User)
					.WithOne(l => l.Location);

			// 1 - Many
				entity.HasOne(n => n.Neighborhood)
					.WithMany(l => l.Locations)
					.HasForeignKey( x => x.NeighborhoodId);
			});

			// 1 - Many
			modelBuilder.Entity<Neighborhood>(entity =>{
				entity.HasMany(l => l.Locations)
					.WithOne(n => n.Neighborhood);
			});
			
		}
	}
}

