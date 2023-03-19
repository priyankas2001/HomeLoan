using DataAccessLayer.Model;
using System;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository.RepositoryImplementation
{
    public interface IAccountRepository
    {
        /*Task CreateRoleAsync(IServiceProvider _serviceProvider);*/
        Task<dynamic> CreateUserAsync(User userModel);
    }
}