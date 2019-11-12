using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace RipBackend.Models.User
{
    public class User
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "неправильный формат почты")]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
        public bool isAdmin { get; set; }
        [Required]
        [Phone(ErrorMessage="неправильный формат телефона")]
        public string phone { get; set; }
    }
}
