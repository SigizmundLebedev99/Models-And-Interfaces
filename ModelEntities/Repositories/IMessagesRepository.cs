using ModelEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ModelEntities.Repositories
{
    public interface IMessagesRepository : IRepository<MessageInfo>
    {
        Task<IEnumerable<MessageInfo>> GetMessagesByUser(User user);
        Task<IEnumerable<MessageInfo>> GetMessagesByOperator(Operator _operator);
    }
}
