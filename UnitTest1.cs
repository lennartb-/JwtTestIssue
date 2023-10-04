using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Contoso.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void JwtTest()
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var descriptor = new SecurityTokenDescriptor();

            var token = jwtTokenHandler.CreateToken(descriptor);

            jwtTokenHandler.WriteToken(token);
        }
    }
}