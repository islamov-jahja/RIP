using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RipBackend.Models.User
{
    public class LoginForm
    {
        [Required]
        [EmailAddress(ErrorMessage = "неправильный формат почты")]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
    }
}
