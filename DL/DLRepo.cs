using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class DLRepo : IDL
    {
        readonly private BucketDBContext _context;

        public DLRepo(BucketDBContext context)
        {
            _context = context;
        }

        public async Task<User> createUserAsync(User user)
        {
            await _context.AddAsync(user);
            await _context.SaveChangesAsync();
            _context.ChangeTracker.Clear();

            return user;
        }

        public async Task<User> getOneUserAsync(string username)
        {
            return await _context.User
                .AsNoTracking()
                .Include(b => b.Bucketlists)
                .Select(u => new User
                {
                    Id = u.Id,
                    Name = u.Name,
                    Username = u.Username,
                    Email = u.Email,
                    Password = u.Password
                })
                .FirstOrDefaultAsync(user => user.Username == username);
        }

        public async Task<User> updateUserAsync(User user)
        {
            _context.Update(user);
            await _context.SaveChangesAsync();
            _context.ChangeTracker.Clear();

            return new User()
            {
                Id = user.Id,
                Name = user.Name,
                Username = user.Username,
                Email = user.Email,
                Password = user.Password
            };
        }

        public async Task DeleteUserAsync(string username)
        {
            _context.Remove(await getOneUserAsync(username));
            await _context.SaveChangesAsync();
            _context.ChangeTracker.Clear();
        }
        
    }
}
