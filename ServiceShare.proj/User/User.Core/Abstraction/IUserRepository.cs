using UserModel;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;


namespace IUserRepo
{
public interface IUserRepository
{
	Task<User> GetUserByIdAsync(string id);
	Task<User> GetUserByEmailAsync(string email);
	Task<User> GetUserByUserNameAsync(string userName);
	Task<User> GetUserByServiceIdAsync(string serviceId);
	Task<User> GetUserBySubsIdAsync(string subsId);
	
	Task<List<User>> GetAllUsersByServiceTypeAsync(string serviceType, int pageNumber, int pageSize);
	
	Task<List<User>> GetAllUsersBySubsTypeAsync(string subsType, int pageNumber, int pageSize);
	Task<List<User>> GetAllUsersAsync(int pageNumber, int pageSize);
	Task UpdateUserAsync(string UserId);
	Task DeleteUserAsync(string UserId);
 }
}