using UserModel;
using Microsoft.AspNetCore.Identity;

namespace UserServiceInterface
{
public interface IUserService
{ 
   	Task<User> GetUserByIdAsync(string id);
	Task<User> GetUserByEmailAsync(string email);
	Task<User> GetUserByUserNameAsync(string userName);
	Task<User> GetUserByServiceIdAsync(string serviceId);
	Task<User> GetAllUsersByServiceTypeAsync(string serviceType);
	Task<User> GetUserBySubsIdAsync(string subsId);
	Task<List<User>> GetAllUsersBySubsTypeAsync(string subsType);
	Task UpdateUserAsync(string id);
	Task DeleteUserAsync(string id);
}
}
