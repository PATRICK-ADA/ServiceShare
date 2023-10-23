public interface IUserRepository
{
	Task<User> GetUserByIdAsync(string id);
	Task<User> GetUserByEmailAsync(string email);
	Task<User> GetUserByUserNameAsync(string userName);
	Task<User> GetUserByServiceIdAsync(string serviceId);
	Task<User> GetUserBySubsIdAsync(string subsId);
	
	Task<List<User> GetAllUsersByServiceTypeAsync(string serviceType, int pageNumber, int pageSize);
	
	Task<List<User>> GetAllUsersBySubsTypeAsync(string subsType, int pageNumber, int pageSize);
	Task<List<User>> GetAllUsersAsync(int pageNumber, int pageSize);
	Task UpdateUserAsync(User user);
	Task DeleteUserAsync(User user);

}