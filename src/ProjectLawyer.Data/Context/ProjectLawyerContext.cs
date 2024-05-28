using Microsoft.EntityFrameworkCore;
using ProjectLawyer.Data.Mappings;
using ProjectLawyer.Domain.Entity;

namespace ProjectLawyer.Data.Context
{
    public class ProjectLawyerContext : DbContext
    {
        public ProjectLawyerContext(DbContextOptions<ProjectLawyerContext> options) : base(options)
        {
        }

        #region Tables
        public DbSet<City> City { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<Client> Client { get; set; } 
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>(new CityMap().Configure);
            modelBuilder.Entity<State>(new StateMap().Configure);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProjectLawyerContext).Assembly);
        }
    }
}
