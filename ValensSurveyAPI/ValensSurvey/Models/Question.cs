namespace ValensSurvey.Models
{
    public class Question
    {
        public int Id { get; set; }
        public int SurveyId { get; set; }
        public string Text { get; set; }
    }
}
