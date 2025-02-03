using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitters.Core.Enitites;

namespace Twitter.DataAccess.Authentication
{
    public interface IJwtTokenHandler
    {
        JwtSecurityToken GenerateAccesToken(User user);
        string GenerateRefreshToken();
    }
}
