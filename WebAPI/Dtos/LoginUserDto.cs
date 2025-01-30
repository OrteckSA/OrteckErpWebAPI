using System.ComponentModel.DataAnnotations;

namespace ERP.WebAPI.Dtos
{
    public class LoginUserDto
    {
        [Required]
        public string Username { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
    }
}
