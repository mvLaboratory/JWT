using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace TokenAPI.Core
{
    public class TokenFactory
    {
        public String Generate()
        {
            var key = "";
            using (RandomNumberGenerator generator = new RNGCryptoServiceProvider())
            {
                byte[] keyData = new byte[32];
                generator.GetBytes(keyData);
                key = Convert.ToBase64String(keyData);
            }

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var header = new JwtHeader(credentials);
            var payload = new JwtPayload
            {
                { "exp", DateTime.Now.AddHours(24)},
                { "userId", "23665548"},
                { "uid", Guid.NewGuid()},
                { "href", @"http://isqft/documents/123/pdf/9987"}
            };

            var secToken = new JwtSecurityToken(header, payload);
            var handler = new JwtSecurityTokenHandler();

            return handler.WriteToken(secToken).ToString();
        }

        public void Validate(String token)
        {

        }
    }
}