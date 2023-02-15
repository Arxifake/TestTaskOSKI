namespace TestTaskOSKI.DataAccess.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int QuestionNumber { get; set; }
        public int TestId { get; set; }
        public Test Test { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
