using TestTaskOSKI.DataAccess.Models;

namespace TestTaskOSKI.DataAccess.Interfaces
{
    public interface IAnswers
    {
        public List<Answer> AnswersByQuestionId(int id);
    }
}
