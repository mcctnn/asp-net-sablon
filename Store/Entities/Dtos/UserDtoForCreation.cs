using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record UserDtoForCreation:UserDto
    {
        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Password can not be null")]
        public String? Password { get; init; }
    }
}