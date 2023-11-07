using IUserRepo;
using Infrastructure.Database;
using UserModel;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ApplicationContext
{
public class UserRepository : IUserRepository
{
	private readonly UserContext _context;
	
	public UserRepository(UserContext context)
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
	
	
	public async Task<IEnumerable<User>> GetAllUsersByServiceTypeAsync(string serviceType, int pageNumber, int pageSize)
{
	return await _context.Users
		.Where(s => s.ServiceType == serviceType)
		.Skip((pageNumber - 1) * pageSize)
		.Take(pageSize)
		.ToListAsync();
}


public async Task<IEnumerable<User>> GetAllUsersBySubsTypeAsync(string subsType, int pageNumber, int pageSize)
{
	
	return await _context.Users.Where(s => s.SubsType == subsType)
	.Skip((pageNumber -1 )*  pageSize)
	.Take(pageSize)
	.ToListAsync();
	
	
}
	
	public async Task<IEnumerable<User>> GetAllUsersAsync(int pageNumber, int pageSize)
	{
		
	 return await _context.Users.Skip((pageNumber-1) * pageSize).Take(pageSize).ToListAsync();
		
	}
	
	public async Task<User> GetUserBySubsIdAsync(string subsId)
	{
		return await _context.Users.FirstOrDefaultAsync(s => s.SubsId == subsId);
	}
	
	public async Task UpdateUserAsync(string userId)
	{
		var user =_context.Users.FirstOrDefault(i => i.UserId == userId);
		
		if (user != null)
		
         _context.Users.Update(user);
		
		await _context.SaveChangesAsync();
	}
	
	public async Task DeleteUserAsync(string userId)
	{
		
		var user = _context.Users.FirstOrDefault(i => i.UserId == userId);
		
		if(user != null)

		_context.Users.Remove(user);

		await _context.SaveChangesAsync();
	}
	
  }
}