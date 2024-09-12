using Microsoft.AspNetCore.Identity;
using PureFood.Core.Domain.Content;
using PureFood.Core.SeedWorks.Enums;
using System.ComponentModel.DataAnnotations;

namespace PureFood.Core.Domain.Identity
{
    public class AppUser : IdentityUser<Guid>
    {
        [Key]
        public Guid UserId { get; set; }
        public string FullName { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
        public string? Address { get; set; }
        public string? Avatar { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime? VipStartDate { get; set; }
        public DateTime? VipExpireDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public Gender? Gender { get; set; }
        public bool Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }

        public Cart Cart { get; set; }


    }
}
