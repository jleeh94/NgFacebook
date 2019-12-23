using System.Collections.Generic;
using System.Threading.Tasks;
using NgFacebook.API.Models;

namespace NgFacebook.API.Data
{
    public interface IFacebookRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<IEnumerable<User>> GetUsers();
         Task<User> GetUser(int id);
    }
}