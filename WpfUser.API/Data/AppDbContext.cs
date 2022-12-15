using Microsoft.EntityFrameworkCore;

namespace WpfUser.API.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().Property(x => x.DateOfBirth).HasColumnType("datetime");
        //modelBuilder.Entity<UserRole>().HasNoKey();
        
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                UserName = "tuananh",
                Password = "Tuananh123.",
                DateOfBirth = new DateTime(1999, 08, 30),
                Address = "Hanoi",
                Email = "tuananh@gmail.com",
                Age = 23,
                Gender = "Male",
                Status = true,
                UserRoleId = 1
            });

        modelBuilder.Entity<Role>().HasData(
            new Role
            {
                Id = 1,
                Name = "Admin"
            },
            new Role
            {
                Id = 2,
                Name = "User"
            });

        modelBuilder.Entity<UserRole>().HasData(
            new UserRole
            {
                Id = 1,
                UserId = 1,
                RoleId = 1
            });
        
        base.OnModelCreating(modelBuilder);
    }
}