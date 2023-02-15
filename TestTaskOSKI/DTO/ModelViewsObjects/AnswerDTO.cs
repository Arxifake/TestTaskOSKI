namespace TestTaskOSKI.DTO.ModelViewsObjects
{
    public class AnswerDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCorrect { get; set; }
        public QuestionDTO? Question { get; set; }
        public int QuestionId { get; set; }
    }
}
