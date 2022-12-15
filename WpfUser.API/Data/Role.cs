using System.ComponentModel.DataAnnotations;

namespace WpfUser.API.Data;

public class Role
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;
    public UserRole UserRole { get; set; }
}