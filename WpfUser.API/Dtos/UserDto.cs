using System.ComponentModel.DataAnnotations;

namespace WpfUser.API.Dtos;

public class UserDto
{
    
}

public class LoginUserDto
{
    [Required]
    [StringLength(250, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
    public string UserName { get; set; } = null!;
    [Required]
    [StringLength(250, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
    public string Password { get; set; } = null!;
}

public class RegisterUserDto : LoginUserDto
{
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
    public DateTime? DateOfBirth { get; set; }

    [Required]
    public string? Address { get; set; }
    
    [Required]
    [DataType(DataType.EmailAddress)]
    public string? Email { get; set; }

    [Range(1, 120, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
    public int? Age { get; set; }

    [Required] public string Gender { get; set; }

    public bool Status { get; set; }

    public int UserRoleId { get; set; }
}

