public interface IUserRepository
{
	Task<User> GetUserByIdAsync(string id);
	Task<User> GetUserByEmailAsync(string email);
	Task<User> GetUserByUserNameAsync(string userName);
	Task<User> GetUserByServiceIdAsync(string serviceId);
	Task<User> GetAllUsersByServiceTypeAsync(string serviceType);
	Task<User> GetUserBySubsIdAsync(string subsId);
	Task<Users> GetAllUsersBySubsTypeAsync(string subsType);
	Task UpdateUserAsync(User user);
	Task DeleteUserAsync(User user);

}