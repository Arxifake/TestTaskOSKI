using TestTaskOSKI.DataAccess.DBContext;
using TestTaskOSKI.DataAccess.Interfaces;
using TestTaskOSKI.DataAccess.Models;

namespace TestTaskOSKI.DataAccess.Repositories
{
    public class Answers : IAnswers
    {
        private readonly IServiceScopeFactory _scopeFactory;
        public Answers(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
        }
        public List<Answer> AnswersByQuestionId(int id)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<TestAppContext>();
                return db.Answers.Where(a => a.QuestionId == id).ToList();
            }
        }
    }
}
