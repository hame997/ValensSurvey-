using ValensSurvey.Models;

namespace ValensSurvey.Services
{
    public interface ISurveyService
    {
        Task<List<Survey>> GetAll();
        public Survey Get(int surveyId);
        public Survey Update(Survey survey);
        Task<Survey> Create(Survey survey);
        public void Delete(int id);
    }
}
