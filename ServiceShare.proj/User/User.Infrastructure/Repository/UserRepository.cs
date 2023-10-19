public class UserRepository : IUserRepository
{
	private readonly UserDbContext _context;
	
	public UserRepository(UserDbContext context)
	{
		_context = context;
		
	}
	
	public async Task<User> GetUserByIdAsync(string id)
	{
		return await _context.Users.FindAsync(id);

	}
   
	public async Task<User> GetUserByEmailAsync(string email)
	{
		return await _context.Users.FirstOrDefaultAsync(e => e.Email == email);
	}
	
	public async Task<User> GetUserByUserNameAsync(string userName)
	{
		
		return await _context.Users.FirstOrDefaultAsync(u => u.UserName == userName);
	}
	
	
	public async Task<User> GetUserByServiceIdAsync(string serviceId)
	{
		return await _context.Users.FirstOrDefaultAsync(s => s.ServiceId == serviceId);
	}
	
	public async Task<List<User>> GetAllUsersByServiceTypeAsync(string serviceType, int pageNumber, int pageSize)
{
    return await _context.Users
        .Where(s => s.ServiceType == serviceType)
        .Skip((pageNumber - 1) * pageSize)
        .Take(pageSize)
        .ToListAsync();
	
	public async Task<User> GetUserBySubsIdAsync(string subsId)
	{
		return await _context.Users.FirstOrDefaultAsync(s => s.SubsId == subsId);
	}
	
	public async Task UpdateUserAsync(User user)
	{
		_context.Users.Update(user);
		await _context.SaveChangesAsync();
	}
	
	public async Task DeleteUserAsync(User user)
	{
		
		_context.Users.Remove(user);
		await _context.SaveChangesAsync();
	}
	

}