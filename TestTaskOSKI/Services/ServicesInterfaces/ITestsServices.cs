using TestTaskOSKI.DTO.ModelViewsObjects;

namespace TestTaskOSKI.Services.ServicesInterfaces
{
    public interface ITestServices
    {
        public List<TestDTO> GetTests(int userId);
        public void SetTestsToUser(int userId);
        public TestDTO GetTest(int Id);
    }
}
