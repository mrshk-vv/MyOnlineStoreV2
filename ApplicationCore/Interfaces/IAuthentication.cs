using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IAsyncAuthentication
    {
        Task<bool> CreateBuyerAsync(string userId);
        Task<bool> CreateManagerAsync(string userId);
        Task<bool> CreateAdminAsync(string userId);
        Task<IdentityResult> CreateUserAsync();
        Task<ApplicationUser> FindUserByEmailAsync(string email);
        Task<ApplicationUser> FindUserByIdAsync(string userId);
        Task SignInAsync(ApplicationUser user);
        Task<SignInResult> SignInAsync(string email, string password);
        Task SignOutAsync();
        Task DeleteUserAsync(string userId);
        Task<ApplicationUser> GetCurrentUserAsync();
        Task<bool> IsInRole(ApplicationUser user, string role);
    }
}
