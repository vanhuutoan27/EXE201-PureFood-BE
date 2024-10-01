using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PureFood.Core.Models.auth
{
    public class AutheticatedResult
    {
        public required string AccessToken { get; set; }
        public required string RefreshToken { get; set; }
        public required DateTime? ExpiredAt { get; set; }
    }
}