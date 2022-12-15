using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfUser.ViewModels
{
    internal class UserViewModel
    { 
        public int Id { get; set; }

        public string UserName { get; set; } = null!;

        public DateTime? DateOfBirth { get; set; }

        public string? Address { get; set; }

        public string? Email { get; set; }
        public int? Age { get; set; }

        public string Gender { get; set; }

        public string Status { get; set; }

        public string Role { get; set; }
    }

    public class CreateUserViewModel
    {
        public string UserName { get; set; } = null!;

        public string Password { get; set; } = null!;

        public DateTime? DateOfBirth { get; set; }

        public string? Address { get; set; }

        public string? Email { get; set; }
        public int? Age { get; set; }

        public string Gender { get; set; }

        //public string Status { get; set; }

        public string Role { get; set; }
    }
}
