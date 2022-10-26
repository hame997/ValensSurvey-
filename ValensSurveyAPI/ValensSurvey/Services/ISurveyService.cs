using ValensSurvey.Models;

namespace ValensSurvey.Services
{
    public interface ISurveyService
    {
        Task<List<Survey>> GetAll();
        public Task<Survey> Get(int surveyId);
        public Task<Survey> Update(Survey survey);
        Task<Survey> Create(Survey survey);
        public Task<bool> Delete(int id);
    }
}
