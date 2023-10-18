public interface IUserService
{ 
    Task<User> GetUserByIdAsync(string id);
    Task<User> GetUserByEmailAsync(string email);
    Task<User> GetUserByUserNameAsync(string userName);
    Task RegisterUserAsync(User user);
    Task UpdateUserAsync(User user);
    Task DeleteUserAsync(User user);
    Task LoginUserAsync(User user);
}
```