using Examensarbete_Quiz.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace Examensarbete_Quiz.Models
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public UserRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IEnumerable<User> GetAllUser
        {
            get
            {
                return _applicationDbContext.Users;
            }
        }

        public User GetUserByID(int userId)
        {
            return _applicationDbContext.Users.FirstOrDefault(u => u.UserID == userId);
        }

        public void EditUser(User user)
        {
            _applicationDbContext.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _applicationDbContext.SaveChanges();
        }

        public void CreateNewUser(User user)
        {
            _applicationDbContext.Users.Add(user);
            _applicationDbContext.SaveChanges();
        }

        public void RemoveUser(int id)
        {
            User user = _applicationDbContext.Users.Find(id);
            _applicationDbContext.Users.Remove(user);
            _applicationDbContext.SaveChanges();
        }
    }
}
