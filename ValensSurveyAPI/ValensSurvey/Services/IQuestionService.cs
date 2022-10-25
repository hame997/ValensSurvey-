using ValensSurvey.Models;

namespace ValensSurvey.Services
{
    public interface IQuestionService
    {
        Task<List<Question>> GetAll();
        public Question Get(int questionId);
        public Question Update(Question question);
        Task<Question> Create(Question question);
        public void Delete(int id);
    }
}
