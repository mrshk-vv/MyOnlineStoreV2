using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace ApplicationCore.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Display(Name = "Имя пользователя")]
        public override string UserName { get; set; }

        [Display(Name = "Email")]
        [EmailAddress]
        public override string Email { get; set; }

        [Display(Name = "Номер телефона")]
        [Phone]
        public override string PhoneNumber { get; set; }

    }
}
