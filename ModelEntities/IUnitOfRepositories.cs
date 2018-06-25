using ModelEntities.Models;
using ModelEntities.Repositories;
using System.Threading.Tasks;

namespace ModelEntities
{
    public interface IUnitOfRepositories
    {
        IMessagesRepository MessagesRepository { get; set; }
        IRepository<Operator> OperatorsRepository { get; set; }
        IUserRepository<User> CommonUsersRepository { get; set; }
        IRegistredUserRepository RegistredUsersRepository { get; set; }
        Task SaveAsync();
    }
}
