

namespace User.Infrastructure.Database
{
	public class UserContext : IdentityDbContext<User>
	{
		
		public Dbset <User> Users {get; set;}
		public IdentityDbContext(DbContextOptions<IdentityDbContext> options) : base(options)
		{
		
		}		
	
		public protected override void OnModelCreating(ModelBuilder modelBuilder)
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
	

public class UserContext : IdentityDbContext<User>
{
	public Dbset <User> Users {get; set;}
	public IdentityDbContext(DbContextOptions<IdentityDbContext> options) : base(options)
	{
		
	}		
	
	public protected override void OnModelCreating(ModelBuilder modelBuilder)
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
 
		
	public override int SaveChanges()
	{
		var entries = ChangeTracker
		.Entries()
		.Where(e => e.Entity is BaseEntity && (
		e.State == EntityState.Added
		|| e.State == EntityState.Modified));
		
		foreach (var entityEntry in entries)
		{
			((BaseEntity)entityEntry.Entity).LastModified = DateTime.UtcNow;
			
			if (entityEntry.State == EntityState.Added)
			{
				((BaseEntity)entityEntry.Entity).Created = DateTime.UtcNow;
			}
		}
		
		return base.SaveChanges();
	}
	
   }
 }

