using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using UserModel;


namespace Infrastructure.Database
{
	public class UserContext : IdentityDbContext<User>
	{
		
		public DbSet<User> Users {get; set;}
		
		public UserContext(DbContextOptions<UserContext> options) : base(options)
		{
		
		}		
	
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<User>().HasData(
			new User
			{
				UserId = "1",
				UserName = "SuperAdmin",
				EmailAddress = ""
			});
		}
		
   }
 }

