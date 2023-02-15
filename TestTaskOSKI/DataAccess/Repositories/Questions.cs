using TestTaskOSKI.DataAccess.DBContext;
using TestTaskOSKI.DataAccess.Interfaces;
using TestTaskOSKI.DataAccess.Models;

namespace TestTaskOSKI.DataAccess.Repositories
{
    public class Questions : IQuestions
    {
        private readonly IServiceScopeFactory _scopeFactory;
        public Questions(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
        }

        public List<Question> GetQuestionsBytestId(int id)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<TestAppContext>();
                return db.Questions.Where(q=>q.TestId==id).ToList();
            }
        }
    }
}
