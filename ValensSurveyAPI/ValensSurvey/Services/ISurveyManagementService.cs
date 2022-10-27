using ValensSurvey.Models;

namespace ValensSurvey.Services
{
    public interface ISurveyManagementService
    {
        Task<List<SurveyManagement>> GetAll();
        public Task<SurveyManagement> Get(int surveyManagementId);
        Task<SurveyManagement> Create(SurveyManagement surveyManagement);
    }
}
