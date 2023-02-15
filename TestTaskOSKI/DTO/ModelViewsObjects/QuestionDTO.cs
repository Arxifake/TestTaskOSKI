namespace TestTaskOSKI.DTO.ModelViewsObjects
{
    public class QuestionDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int QuestionNumber { get; set; }
        public TestDTO? Test { get; set; }
        public int TestId { get; set; }
        public ICollection<AnswerDTO> Answers { get; set;}
    }
}
