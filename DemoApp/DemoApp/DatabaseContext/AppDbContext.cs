using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DemoApp.DatabaseContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base ("DefaultConnection")
        {

        }
        protected override void OnModelCreating (DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<UserInfo>().HasRequired<Position>(x => x.Position_FK)
                .WithMany(x => x.UserInfo).HasForeignKey(x => x.PositionId).WillCascadeOnDelete(false);
            //modelBuilder.Entity<UserInfo>().HasRequired(x => x.UserInfo_FK)
            //    .WithMany(x => x.UserInfoLst).HasForeignKey(x => x.Supervisor_Id).WillCascadeOnDelete(true);
            // modelBuilder.Entity<Position>().Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<UserInfo>().Property(x => x.Supervisor_Id).IsOptional();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<Position> Position { get; set; }
    }
}