using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record ResetPasswordDto
    {
        public String? UserName { get; init; }
        
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required.")]
        public String? Password { get; init; }
        
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "The field is required.")]
        [Compare("Password",ErrorMessage ="Password and the field must be same")]
        public String? ConfirmPassword { get; init; }
    }
}