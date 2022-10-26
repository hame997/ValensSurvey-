using ValensSurvey.Models;

namespace ValensSurvey.Services
{
    public class UserService : IUserService
    {
        private readonly IDbService _dbService;
        public UserService (IDbService dbService)
        {
            _dbService = dbService;
        }
        public async Task<User> Create(User user)
        {
            var result =
            await _dbService.EditData(
                "INSERT INTO public.users (full_name, password, role) VALUES (@FullName, @Password, @Role)",
                user);
            return user;
        }
        public async Task<bool> Delete(int id)
        {
            var deleteQuestion = await _dbService.EditData("DELETE FROM public.users WHERE id=@Id", new { id });
            return true;
        }
        public async Task<User> Get(int userId)
        {
            var userList = await _dbService.GetAsync<User>("SELECT * FROM public.users where id=@userId", new { userId });
            return userList;
        }
        public async Task<List<User>> GetAll()
        {
            var userList = await _dbService.GetAll<User>("SELECT * FROM public.users",new { });
         
            return userList;
        }
        public async Task<User> Update(User user)
        {
            var updateUser =
                        await _dbService.EditData(
                            "Update public.users SET full_name=@FullName, password=@Password, role=@Role WHERE id=@Id",
                            user);
            return user;
        }
    }
}
