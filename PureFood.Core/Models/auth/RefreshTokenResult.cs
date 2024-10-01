using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PureFood.Core.Models.auth
{
    public class RefreshTokenResult
    {
         public required string AccessToken { get; set; }
        public required string RefreshToken { get; set; }
    }
}