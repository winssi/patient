using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore; 
using System.ComponentModel.DataAnnotations;

namespace  Model
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string   Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
    
}