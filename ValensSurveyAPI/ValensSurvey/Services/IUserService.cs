using ValensSurvey.Models;

namespace ValensSurvey.Services
{
    public interface IUserService
    {
        Task<List<User>> GetAll();
        public Task<User> Get(int userId);
        public Task<User> Update(User user);
        Task<User> Create(User user);
        public Task<bool> Delete(int id);
    }
}
