using TestTaskOSKI.DataAccess.Models;

namespace TestTaskOSKI.DTO.ModelViewsObjects
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public ICollection<Test>? Tests { get; set; }
    }
}
