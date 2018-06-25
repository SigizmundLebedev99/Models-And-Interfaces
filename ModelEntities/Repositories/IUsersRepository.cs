using ModelEntities.Models;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ModelEntities.Repositories
{
    public interface IUserRepository<T> : IRepository<T> where T : User
    {
        Task<T> FindByPhone(string phone);
        Task<bool> CheckUniquePhone(string phone);
    }
}
