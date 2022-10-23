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

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User Get(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public User Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
