namespace TestTaskOSKI.DataAccess.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public ICollection<Test>? Tests { get; set; }
    }
}
