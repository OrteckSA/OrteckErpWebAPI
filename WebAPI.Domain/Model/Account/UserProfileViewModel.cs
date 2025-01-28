using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Model.Account
{
    public class UserProfileViewModel
    {
        public string Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        public string MobileNumber { get; set; }

        public string OrganizationName { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string ProfileImage { get; set; }

        public string Email { get; set; }
        public string Description { get; set; }

    }
}
