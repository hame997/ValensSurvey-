using ValensSurvey.Models;

namespace ValensSurvey.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IDbService _dbService;
        public QuestionService(IDbService dbService)
        {
            _dbService = dbService;
        }
        public async Task<Question> Create(Question question)
        {
            var result =
            await _dbService.EditData(
                "INSERT INTO public.questions (survey_id, text) VALUES (@SurveyId, @Text)",
                question);
            return question;
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        public Question Get(int questionId)
        {
            throw new NotImplementedException();
        }
        public Task<List<Question>> GetAll()
        {
            throw new NotImplementedException();
        }
        public Question Update(Question question)
        {
            throw new NotImplementedException();
        }
    }
}
