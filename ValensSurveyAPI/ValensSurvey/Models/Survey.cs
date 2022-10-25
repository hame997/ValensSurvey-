namespace ValensSurvey.Models
{
    public class Survey
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime SurveyStartAndEnd { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
    }
}
