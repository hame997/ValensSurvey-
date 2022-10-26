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
        public async Task<bool> Delete(int id)
        {
            var deleteQuestion = await _dbService.EditData("DELETE FROM public.surveys WHERE id=@Id", new { id });
            return true;
        }
        public async Task<Survey> Get(int surveyId)
        {
            var surveyList = await _dbService.GetAsync<Survey>("SELECT * FROM public.surveys where id=@id", new { surveyId });
            return surveyList;
        }
        public async Task<List<Survey>> GetAll()
        {
            var surveyList = await _dbService.GetAll<Survey>("SELECT * FROM public.surveys", new { });
            return surveyList;
        }
        public async Task<Survey> Update(Survey survey)
        {
            var updateSurvey =
                                    await _dbService.EditData(
                                        "Update public.surveys SET title=@Title, survey_start_and_end=@SurveyStartAndEnd, description=@Description, create_by=@CreatedBy WHERE id=@Id",
                                        survey);
            return survey;
        }
    }
}
