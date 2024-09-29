using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PureFood.Core.Models.auth
{
    public class MeResponse
    {
     public Guid UserId { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
        public string PhoneNumber { get; set; }
        public bool CitizenId { get; set; }
        public bool DrivingLicense { get; set; }
        public string Role { get; set; }
    }
}