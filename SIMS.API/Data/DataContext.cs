using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SIMS.API.Models;

namespace SIMS.API.Data
{
    public class DataContext : IdentityDbContext<User, Role, int, IdentityUserClaim<int>, 
        UserRole, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}
        public DbSet<Value> Values { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<BachelorsMentor> BachelorsMentors { get; set; }
        public DbSet<BachelorsProjectAdvisor> BachelorsProjectAdvisors { get; set; }
        public DbSet<BachelorsThesisAdvisor> BachelorsThesisAdvisors { get; set; }
        public DbSet<MastersProjectAdvisor> MastersProjectAdvisors { get; set; }
        public DbSet<MastersThesisAdvisor> MastersThesisAdvisors { get; set; }
        public DbSet<MastersCommittee> MastersCommittees { get; set; }
        public DbSet<DoctorateAdvisor> DoctorateAdvisors { get; set; }
        public DbSet<ExternalAdvisor> ExternalAdvisors { get; set; }
        public DbSet<DoctorateCommittee> DoctorateCommittees { get; set; }
        public DbSet<ExitSurvey> ExitSurveys { get; set; }
        public DbSet<GradSeniorSurvey> GradSeniorSurveys { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserRole>(userRole => 
            {
                userRole.HasKey(ur => new {ur.UserId, ur.RoleId});
                
                userRole.HasOne(ur => ur.Role)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

                userRole.HasOne(ur => ur.User)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();
            });

            builder.Entity<BachelorsMentor>(bachelorsMentor =>
            {
                bachelorsMentor.HasKey(m => new {m.UserId});
                //bachelorsMentor.HasOne(u => u.User);

            });

            builder.Entity<BachelorsProjectAdvisor>(bachelorsAdvisor =>
            {
                bachelorsAdvisor.HasKey(a => new {a.UserId});
            });

            builder.Entity<BachelorsThesisAdvisor>(bachelorsAdvisor =>
            {
                bachelorsAdvisor.HasKey(a => new {a.UserId});
            });

            builder.Entity<MastersProjectAdvisor>(mastersAdvisor =>
            {
                mastersAdvisor.HasKey(a => new {a.UserId});
            });

            builder.Entity<MastersThesisAdvisor>(mastersAdvisor =>
            {
                mastersAdvisor.HasKey(a => new {a.UserId});
            });

            builder.Entity<MastersCommittee>(mastersCommittee =>
            {
                mastersCommittee.HasKey(c => new {c.UserId});
                
            });

            builder.Entity<DoctorateAdvisor>(doctorateAdvisor =>
            {
                doctorateAdvisor.HasKey(a => new {a.UserId});
            });

            builder.Entity<ExternalAdvisor>(externalAdvisor =>
            {
                externalAdvisor.HasKey(a => new {a.UserId});
            });

            builder.Entity<DoctorateCommittee>(doctorateCommittee =>
            {
                doctorateCommittee.HasKey(c => new {c.UserId});
                
            });

        }
        
    }
    
}
