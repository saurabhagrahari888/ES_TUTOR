using ES_TUTOR.Models;
using Microsoft.EntityFrameworkCore;

namespace ES_TUTOR.Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Login> UserLogins { get; set; }
        public DbSet<StudentRegisterationDetails> StudentDetails { get; set; }
        public DbSet<TeacherRegisterationDetails> TeacherDetails { get; set; }
        public DbSet<HomeTutorRegisterationDetails> HomeTutorDetails { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            {
                //modelBuilder.Entity<MthUser>().HasOne(u => u.MthRoles).WithMany(r => r.MthUsers).HasForeignKey(u => u.RoleId);

                //modelBuilder.Entity<MthWorkerWorkInfo>().HasMany(u => u.MthWorkerWorkInfoItems).WithOne(r => r.MthWorkerWorkInfo).HasForeignKey(u => u.WorkerWorkInfoId);

                //modelBuilder.Entity<MthWorkerWorkInfoItems>().HasOne(r => r.MthCommodities).WithMany(r => r.MthWorkerWorkInfoItems).HasForeignKey(u => u.CommodityId);

                //modelBuilder.Entity<MthWorkers>().HasMany(r => r.MthWorkerWorkInfos).WithOne(r => r.MthWorkers).HasForeignKey(u => u.WorkerId);

                //modelBuilder.Entity<MthWorkers>().HasMany(r => r.MthWorkerPayments).WithOne(r => r.MthWorkers).HasForeignKey(u => u.WorkerId);

                //modelBuilder.Entity<MthUser>()
                //     .HasMany(e => e.MthUserRoutes)
                //     .WithOne(e => e.MthUser)
                //     .HasForeignKey(e => e.UserId)
                //     .IsRequired();
            }

        }
    }
}
