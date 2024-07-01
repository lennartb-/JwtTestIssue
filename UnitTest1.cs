using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.JsonWebTokens;
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

        [TestMethod]
        public void JsonWebTokenTest()
        {
            var jsonWebTokenHandler = new JsonWebTokenHandler();
            var descriptor = new SecurityTokenDescriptor();

            var token = jsonWebTokenHandler.CreateToken(descriptor);
        }
    }
}
