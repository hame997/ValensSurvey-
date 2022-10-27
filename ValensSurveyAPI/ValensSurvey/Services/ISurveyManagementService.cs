using ValensSurvey.Models;

namespace ValensSurvey.Services
{
    public interface ISurveyManagementService
    {
        Task<List<SurveyManagement>> GetAll();
        public Task<SurveyManagement> Get(int surveyManagementId);
        public Task<SurveyManagement> Update(SurveyManagement surveyManagement);
        Task<SurveyManagement> Create(SurveyManagement surveyManagement);
        public Task<bool> Delete(int id);
    }
}
