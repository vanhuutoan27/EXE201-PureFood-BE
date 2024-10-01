using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PureFood.Core.Models.content.Requests
{
    public class CreateUpdateUserRequest
    {
        public string FullName { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string Role { get; set; }
    }
}