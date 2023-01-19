using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserAdminPortal.API.Models;

namespace UserAdminPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly UserAdminContext _context;
        public UserController(UserAdminContext userContext)
        {
            _context = userContext;
                    
        }


        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody]User userObj)
        {
            // Edge case for when/if input is null
            if (userObj == null) 
            {
                return BadRequest();
            }

            // When user is not authenticated, call line 34.. When user is authenticated, call line 41..
            var user = await _context.Users.FirstOrDefaultAsync(token => token.UserName == userObj.UserName && token.Password == userObj.Password);
            if (user == null) 
            {
                return NotFound(new
                {
                    Message = "User Not Found!"
                });
            }
            return Ok(new
            {
                Message = "Login Successful!"
            });
        }


        [HttpPost("registration")]
        public async Task<IActionResult> Registration([FromBody] User userObj)
        {
            // Edge case for empty registration
            if(userObj == null)
            {
                return BadRequest();
            }

            await _context.Users.AddAsync(userObj);
            await _context.SaveChangesAsync();
            return Ok(new
            {
                Message = "User Registered!"
            });


        }

    }
}
