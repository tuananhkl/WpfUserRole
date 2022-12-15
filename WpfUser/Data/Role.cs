using System.ComponentModel.DataAnnotations;

namespace WpfUser.Data;

public class Role
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;
}