using System.ComponentModel.DataAnnotations;

namespace WpfUser.Data;

public class UserRole
{
    [Key]
    public int Id { get; set; }
    public int UserId { get; set; }
    public int RoleId { get; set; }

    public User User { get; set; }
    public Role Role { get; set; }
}