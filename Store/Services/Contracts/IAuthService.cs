using Entities.Dtos;
using Microsoft.AspNetCore.Identity;

namespace Services.Contracts
{
    public interface IAuthService
    {
        IEnumerable<IdentityRole>Roles{get;}
        IEnumerable<IdentityUser>Users{get;}
        Task<IdentityUser> GetOneUser(string userName);
        Task<UserDtoForUpdate> GetOneUserForUpdate(string userName);
        Task<IdentityResult> CreateUser(UserDtoForCreation userDto);
        Task Update(UserDtoForUpdate userDto);
        Task<IdentityResult> ResetPassword(ResetPasswordDto resetpDto);
        Task<IdentityResult> DeleteOneUser(string userName);
    }
}