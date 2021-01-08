using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Histocity_Website.Models
{
    public partial class User
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailID { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public Guid ActivationCode { get; set; }

        public Boolean isEmailVerified { get; set; }

    }
}
