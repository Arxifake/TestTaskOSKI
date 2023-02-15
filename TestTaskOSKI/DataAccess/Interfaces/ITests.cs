using TestTaskOSKI.DataAccess.Models;

namespace TestTaskOSKI.DataAccess.Interfaces
{
    public interface ITests
    {
        public List<Test> GetTests(int userId);
        public void SetTestsToUsers(int userId);
        public Test GetTest(int id);
    }
}
