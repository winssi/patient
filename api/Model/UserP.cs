using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore; 
using System.ComponentModel.DataAnnotations;

namespace  Model
{
    public class UserP 
    {
        public int Id { get; set; }

        [Display(Name = "E-mail")]
        [Required]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmer le mot de passe ")]
        [Compare("Password", ErrorMessage = "Le mot de passe et le mot de passe de confirmation ne correspondent pas.")]
        public string ConfirmPassword { get; set; }

    }
    
}