namespace TestTaskOSKI.DTO.ModelViewsObjects
{
    public class TestDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<QuestionDTO> Questions { get; set;}
    }
}
