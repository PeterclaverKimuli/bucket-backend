using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DL
{
    public interface IDL
    {
        //User CRUD
        Task<User> createUserAsync(User user);
        Task<User> getOneUserAsync(string username);
        Task<User> updateUserAsync(User user);
        Task DeleteUserAsync(string username);
    }
}
