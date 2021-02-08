using System.Threading.Tasks;
using dotnet_rpg_udemy.Models;
using RPG_Udemy.Models;

namespace RPG_Udemy.Data
{
    public interface IAuthRepository
    {
        Task<ServiceResponse<int>> Register(User user, string password);
        Task<ServiceResponse<string>> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}