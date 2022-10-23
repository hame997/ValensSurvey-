using ValensSurvey.Models;

namespace ValensSurvey.Services
{
    public interface IUserService
    {
        Task<List<User>> GetAll();
        public User Get(int userId);
        public User Update(User user);
        Task<User> Create(User user);
        public void Delete(int id);
    }
}
