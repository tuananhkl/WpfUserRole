using System;
using Microsoft.EntityFrameworkCore;
using WpfUser.Common.Const;
using WpfUser.Data;

namespace WpfUser.Data;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Role> Roles { get; set; } = null!;
    public DbSet<UserRole> UserRoles { get; set; } = null!;  

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Old Code

        //modelBuilder.Entity<User>Property(x => x.DateOfBirth).HasColumnType("datetime");
        //modelBuilder.Entity<UserRole>().HasNoKey();

        // modelBuilder.Entity<User>().HasData(
        //     new User
        //     {
        //         Id = 1,
        //         UserName = "tuananh",
        //         Password = "Tuananh123.",
        //         DateOfBirth = new DateTime(1999, 08, 30),
        //         Address = "Hanoi",
        //         Email = "tuananh@gmail.com",
        //         Age = 23,
        //         Gender = "Male",
        //         Status = true,
        //         UserRoleId = 1
        //     });
        //
        // modelBuilder.Entity<Role>().HasData(
        //     new Role
        //     {
        //         Id = 1,
        //         Name = "Admin"
        //     },
        //     new Role
        //     {
        //         Id = 2,
        //         Name = "User"
        //     });
        //
        // modelBuilder.Entity<UserRole>().HasData(
        //     new UserRole
        //     {
        //         Id = 1,
        //         UserId = 1,
        //         RoleId = 1
        //     });

        #endregion

        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(DatabaseConfiguration.DEFAULT_CONNECTION_STRING);

        base.OnConfiguring(optionsBuilder);
    }
}