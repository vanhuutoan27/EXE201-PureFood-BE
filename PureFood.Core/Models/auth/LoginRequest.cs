using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PureFood.Core.Models.auth
{
    public class LoginRequest
    {
         public required string Email { get; set; }
        public required string Password { get; set; }
    }
}