using TestTaskOSKI.DataAccess.Models;

namespace TestTaskOSKI.DataAccess.Interfaces
{
    public interface IQuestions
    {
        public List<Question> GetQuestionsBytestId(int id);
    }
}
