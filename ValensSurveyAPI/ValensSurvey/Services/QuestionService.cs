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
        public async Task<bool> Delete(int id)
        {
            var deleteQuestion = await _dbService.EditData("DELETE FROM public.questions WHERE id=@Id", new { id });
            return true;
        }
        public async Task<Question> Get(int questionId)
        {
            var questionList = await _dbService.GetAsync<Question>("SELECT * FROM public.questions where id=@questionId", new { questionId });
            return questionList;
        }
        public async Task<List<Question>> GetAll()
        {
            var questionList = await _dbService.GetAll<Question>("SELECT * FROM public.questions", new { });
            return questionList;
        }
        public async Task<Question> Update(Question question)
        {
            var updateQuestion =
                                    await _dbService.EditData(
                                        "Update public.questions SET survey_id=@SurveyId, text=@Text WHERE id=@Id",
                                        question);
            return question;
        }
    }
}
