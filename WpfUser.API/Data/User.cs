using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WpfUser.API.Data;

public class User
{
    [Key] public int Id { get; set; }

    [Column(TypeName = "nvarchar(150)")]
    public string UserName { get; set; } = null!;

    [Column(TypeName = "nvarchar(250)")]

    public string Password { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? DateOfBirth { get; set; }

    [Column(TypeName = "nvarchar(250)")]
    public string? Address { get; set; }

    [Column(TypeName = "nvarchar(250)")]
    public string? Email { get; set; }
    public int? Age { get; set; }

    [Required] public string Gender { get; set; }

    public bool Status { get; set; }
    
    public UserRole UserRole { get; set; }
}