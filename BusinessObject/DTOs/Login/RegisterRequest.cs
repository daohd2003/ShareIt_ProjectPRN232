using BusinessObject.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.DTOs.Login
{
    public class RegisterRequest
    {
        public string FullName { get; set; } = String.Empty;
        [EmailAddress(ErrorMessage = "Email format is invalid.")]
        [MaxLength(128)]
        public string Email { get; set; } = String.Empty;

        [MinLength(6)]
        [SpecialCharacter]
        public string Password { get; set; } = String.Empty;
    }
}
