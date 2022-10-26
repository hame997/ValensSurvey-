using ValensSurvey.Models;

namespace ValensSurvey.Services
{
    public interface IQuestionService
    {
        Task<List<Question>> GetAll();
        public Task<Question> Get(int questionId);
        public Task<Question> Update(Question question);
        Task<Question> Create(Question question);
        public Task<bool> Delete(int id);
    }
}
