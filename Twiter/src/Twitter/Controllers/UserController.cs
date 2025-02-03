using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using Twitter.Application.Service;
using Twitter.Application.Service.lmpl;
using Twitter.DataAccess.Authentication;
using Twitter.DataAccess.DTO;

namespace Twitter.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IJwtTokenHandler _jwtTokenHandler;
        public readonly TokenService _tokenService;

        public UserController(IUserService userService, IJwtTokenHandler jwtTokenHandler, TokenService tokenService)
        {
            _userService = userService;
            _jwtTokenHandler = jwtTokenHandler;
            _tokenService = tokenService;
        }
        [HttpPost("create-user")]
        public async Task<IActionResult> AddUser(UserDTO userForCreationDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var CreateUser = await _userService.AddUserAsync(userForCreationDTO);
                var accesTokent = _jwtTokenHandler.GenerateAccesToken(CreateUser);
                var refreshToken = _jwtTokenHandler.GenerateRefreshToken();

                return Ok(new
                {
                    AccessToken = new JwtSecurityTokenHandler().WriteToken(accesTokent),
                    RefreshToken = refreshToken,
                    User = CreateUser
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }
        [HttpPut("update-user/{id}")]
        public async Task<IActionResult> UpdateUser([FromRoute] Guid id, UserDTO userDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var res = await _userService.UpdateUserAsync(id, userDTO);
            return res == null ? NotFound() : Ok(res);
        }
        [HttpDelete("Delete/{ID}")]
        public async Task<IActionResult> DeleteUser([FromRoute] Guid ID)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var res = await _userService.DeleteUserAsync(ID);
            return res == null ? NotFound() : Ok(res);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
