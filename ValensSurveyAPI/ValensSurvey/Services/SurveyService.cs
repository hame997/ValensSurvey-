using ValensSurvey.Models;

namespace ValensSurvey.Services
{
    public class SurveyService : ISurveyService
    {
        private readonly IDbService _dbService;
        public SurveyService(IDbService dbService)
        {
            _dbService = dbService;
        }
        public async Task<Survey> Create(Survey survey)
        {
            var result =
            await _dbService.EditData(
                "INSERT INTO public.surveys (title, survey_start_and_end, description, create_by) VALUES (@Title, @SurveyStartAndEnd, @Description, @CreatedBy)",
                survey);
            return survey;
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        public Survey Get(int surveyId)
        {
            throw new NotImplementedException();
        }
        public Task<List<Survey>> GetAll()
        {
            throw new NotImplementedException();
        }
        public Survey Update(Survey survey)
        {
            throw new NotImplementedException();
        }
    }
}
