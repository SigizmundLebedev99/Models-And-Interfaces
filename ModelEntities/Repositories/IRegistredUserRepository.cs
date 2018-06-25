using ModelEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ModelEntities.Repositories
{
    public interface IRegistredUserRepository : IUserRepository<RegistredUser>
    {
        Task<bool> CheckUniqueEmail(string Email);
    }
}
