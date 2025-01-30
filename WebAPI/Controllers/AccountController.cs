using DAL.Services;
using ERP.Domain.Entity;
using ERP.Domain.UnitOfWork;
using ERP.WebAPI.Dtos;
using ERP.WebAPI.Services.AccountServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ERP.WebAPI.Controllers
{
    /// <summary>
    /// Controller for managing user accounts, including authentication and retrieval of user data.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IErpUnitOfWork _erpUnitOfWork;
        private readonly IUserServiceApi _userServiceApi;
        private readonly IConfiguration _config;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountController"/> class.
        /// </summary>
        /// <param name="erpUnitOfWork">Unit of work for accessing repositories.</param>
        /// <param name="userServiceApi">Service for handling user-related operations.</param>
        /// <param name="config">Configuration settings.</param>
        public AccountController(IErpUnitOfWork erpUnitOfWork, IUserServiceApi userServiceApi, IConfiguration config)
        {
            _erpUnitOfWork = erpUnitOfWork;
            _userServiceApi = userServiceApi;
            _config = config;
        }

        /// <summary>
        /// Retrieves all users from the system.
        /// </summary>
        /// <returns>A list of users.</returns>
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _erpUnitOfWork.Repository<User>().GetList();
            return Ok(users);
        }

        /// <summary>
        /// Logs in a user and returns a JWT token if successful.
        /// </summary>
        /// <param name="loginUserDto">The user details for login.</param>
        /// <returns>An action result with a JWT token or an error message.</returns>
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUserDto loginUserDto)
        {
            if (ModelState.IsValid)
            {
                // Attempt to find the user by username
                var userModel = await _userServiceApi.FindByCredentialAsync(loginUserDto.Username, loginUserDto.Password);

                if (userModel != null)
                {
                    // Generate JWT token
                    JwtSecurityToken token = GenerateJwtToken(userModel, loginUserDto);

                    return Ok(new
                    {
                        token = new JwtSecurityTokenHandler().WriteToken(token),
                        expiration = token.ValidTo
                    });
                }

                return Unauthorized("Invalid username/password");
            }

            return BadRequest(ModelState);
        }

        /// <summary>
        /// Generates a JWT token for an authenticated user.
        /// </summary>
        /// <param name="userModel">The authenticated user.</param>
        /// <param name="loginUserDto">Login details.</param>
        /// <returns>A JWT security token.</returns>
        private JwtSecurityToken GenerateJwtToken(User userModel, LoginUserDto loginUserDto)
        {
            // Generate JWT token
            List<Claim> claims = new()
                        {
                            new Claim(ClaimTypes.Name, loginUserDto.Username),
                            new Claim(ClaimTypes.NameIdentifier, userModel.GUID.ToString()),
                            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        };

            //var roles = await _userServiceApi.GetRolesAsync(userModel);
            //foreach (var role in roles)
            //{
            //    claims.Add(new Claim(ClaimTypes.Role, role));
            //}

            // Create signing credentials using the security key
            SecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:securityKey"]));
            SigningCredentials signingCredentials = new(key: securityKey, algorithm: SecurityAlgorithms.HmacSha256);

            // Create the JWT token
            JwtSecurityToken token = new(
                issuer: _config["Jwt:validIssuer"],
                audience: _config["Jwt:validAudience"],
                claims: claims,
                expires: DateTime.UtcNow.AddHours(double.Parse(_config["Jwt:expirationDurationInHours"] ?? "1")),
                signingCredentials: signingCredentials);

            return token;
        }
    }
}
