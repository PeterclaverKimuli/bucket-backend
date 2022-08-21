using System;
using System.Collections.Generic;
using System.Text;
using Models;
using DL;
using System.Threading.Tasks;

namespace BL
{
    public class BLRepo : IBL
    {
        readonly private IDL _repo;

        public BLRepo(IDL repo)
        {
            _repo = repo;
        }

        public async Task<User> createUserAsync(User user)
        {
            return await _repo.createUserAsync(user);
        }

        public async Task DeleteUserAsync(string username)
        {
            await _repo.DeleteUserAsync(username);
        }

        public async Task<User> getOneUserAsync(string username)
        {
            return await _repo.getOneUserAsync(username);
        }

        public async Task<User> updateUserAsync(User user)
        {
            return await _repo.updateUserAsync(user);
        }
    }
}
