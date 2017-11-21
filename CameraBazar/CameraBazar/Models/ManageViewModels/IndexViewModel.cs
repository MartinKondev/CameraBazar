using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CameraBazar.Models.ManageViewModels
{
    public class IndexViewModel
    {
        [RegularExpression(Constants.UserNameRegexPattern)]
        public string Username { get; set; }

        public bool IsEmailConfirmed { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Phone number")]
        [RegularExpression(Constants.UserPhoneNumberRegexPattern)]
        public string PhoneNumber { get; set; }

        public string StatusMessage { get; set; }
    }
}
