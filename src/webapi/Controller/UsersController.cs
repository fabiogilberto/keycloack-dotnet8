using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace webapi.Controller
{
    [ApiController]
    [Route("[Controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public IActionResult Get()
        {
            var roles = User.Claims.Where(x => x.Type.Equals(ClaimTypes.Role));
            var name = User.Claims.FirstOrDefault(x => x.Type.Equals("name"));

            var rolesNames = new List<string>();

            foreach (var role in roles)
            {
                rolesNames.Add(role.Value);
            }

            return Ok(new
            {
                Name = name?.Value,
                Roles = rolesNames
            });
        }

        [HttpGet("adm")]
        [Authorize(Roles = "adm")]
        public IActionResult Adm()
        {
            var roles = User.Claims.Where(x => x.Type.Equals(ClaimTypes.Role));
            var name = User.Claims.FirstOrDefault(x => x.Type.Equals("name"));

            var rolesNames = new List<string>();

            foreach (var role in roles)
            {
                rolesNames.Add(role.Value);
            }

            return Ok(new
            {
                Name = name?.Value,
                Roles = rolesNames
            });
        }
    }
}
