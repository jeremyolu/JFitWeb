using JFit.Web.Models;
using JFit.Web.Repositories.Interfaces;

namespace JFit.Web.Repositories
{
    public class UserRepository : IUserRepository
    {
        public UserRepository() {}

        public List<User> GetUsers()
        {
            return new List<User>
            {
                new User { Id = 1001, Email = "james.greenwood@aol.com", Password = "password12345*" },
                new User { Id = 1002, Email = "james.greenwood@aol.com", Password = "querty95" },
                new User { Id = 1003, Email = "james.greenwood@aol.com", Password = "football123" }
            };
        }
        public User? GetUser(int? id)
        {
            if (id == null)
            {
                throw new Exception("User id cannot be null");
            }

            var users = GetUsers();

            if (users != null)
            {
                var user = users.FirstOrDefault(u => u.Id == id);

                return user;
            }

            return null;
        }
    }
}
