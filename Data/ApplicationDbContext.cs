using HRIS.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HRIS.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<User> UsersTable { get; private set; }

        public IQueryable<User> GetUser(User inputUser)
        {
            return UsersTable.Where(user => user.Id == inputUser.Id);
        }
        
        public IQueryable<User> GetUser(string username, string password) {
            return UsersTable.Where(user => user.Username == username && user.Password == password);
        }


    }
}
