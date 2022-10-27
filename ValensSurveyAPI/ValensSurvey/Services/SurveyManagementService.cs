using ValensSurvey.Models;

namespace ValensSurvey.Services
{
    public class SurveyManagementService : ISurveyManagementService
    {
        private readonly IDbService _dbService;
        public SurveyManagementService(IDbService dbService)
        {
            _dbService = dbService;
        }
        public async Task<SurveyManagement> Create(SurveyManagement surveyManagement)
        {
            var result =
                        await _dbService.EditData(
                            "INSERT INTO public.survey_managements (user_id, survey_id, note) VALUES (@UserId, @SurveyId, @Note)",
                            surveyManagement);
            return surveyManagement;
        }
        public async Task<SurveyManagement> Get(int id)
        {
            var surveyManagementIdList = await _dbService.GetAsync<SurveyManagement>("SELECT * FROM public.survey_managements where user_id=@Id", new { id });
            return surveyManagementIdList;
        }
        public async Task<List<SurveyManagement>> GetAll()
        {
            var surveyManagementList = await _dbService.GetAll<SurveyManagement>("SELECT * FROM public.survey_managements", new { });

            return surveyManagementList;
        }
    }
}
