using System;
using Models;
using System.Threading.Tasks;

namespace BL
{
    public interface IBL
    {
        Task<User> createUserAsync(User user);
        Task<User> getOneUserAsync(string username);
        Task<User> updateUserAsync(User user);
        Task DeleteUserAsync(string username);
    }
}
