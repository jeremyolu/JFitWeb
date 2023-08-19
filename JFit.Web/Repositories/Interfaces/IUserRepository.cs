using JFit.Web.Models;

namespace JFit.Web.Repositories.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetUsers();
        User? GetUser(int? id);
    }
}
