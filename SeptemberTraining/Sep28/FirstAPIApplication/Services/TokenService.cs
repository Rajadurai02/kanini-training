using FirstAPIApplication.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace FirstAPIApplication.Services
{
    public class TokenService : ITokenService
    {
        private readonly SymmetricSecurityKey _key;

        public TokenService(IConfiguration configuration)
        {
            _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["MyToken"]));
        }
        public string CreateToken(UserDTO userDTO)
        {
            //claim
            var Claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.NameId,userDTO.Id)
            };
            //credential
            var cred = new SigningCredentials(_key, SecurityAlgorithms.HmacSha512Signature);
            //token description
            var tokenDesc = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(Claims),
                Expires = DateTime.Now.AddDays(7),
                SigningCredentials = cred
            };
            //Generate token
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDesc);
            return tokenHandler.WriteToken(token);
        }
    }
}
