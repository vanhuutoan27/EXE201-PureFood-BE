using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PureFood.Core.Models.content.Responses
{
    public class UserReponse
    {
        public Guid UserId { get; set; }
        public string FullName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Avatar { get; set; }
        public DateTime? Dob { get; set; }
        public string? Gender { get; set; }
        public string Role { get; set; }
        public bool Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}