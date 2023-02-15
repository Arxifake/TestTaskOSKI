using AutoMapper;
using TestTaskOSKI.DataAccess.Interfaces;
using TestTaskOSKI.DTO.ModelViewsObjects;
using TestTaskOSKI.Services.ServicesInterfaces;

namespace TestTaskOSKI.Services.TestsServices
{
    public class TestsServices : ITestServices
    {
        private readonly IMapper _mapper;
        private readonly ITests _testsRepo;
        private readonly IQuestions _questRepo;
        private readonly IAnswers _answersRepo;
        public TestsServices(ITests testsRepo,IMapper mapper, IQuestions questRepo, IAnswers answersRepo)
        {
            _mapper = mapper;
            _testsRepo = testsRepo;
            _questRepo = questRepo;
            _answersRepo = answersRepo;
        }

        public TestDTO GetTest(int Id)
        {
            var test = _mapper.Map<TestDTO>(_testsRepo.GetTest(Id));
            test.Questions = _mapper.Map<IEnumerable<QuestionDTO>>(_questRepo.GetQuestionsBytestId(Id)).ToList();
            foreach (var question in test.Questions) 
            {
                question.Answers = _mapper.Map<IEnumerable<AnswerDTO>>(_answersRepo.AnswersByQuestionId(question.Id)).ToList();
            }
            return test;

        }

        public List<TestDTO> GetTests(int userId)
        {
            return _mapper.Map<IEnumerable<TestDTO>>(_testsRepo.GetTests(userId)).ToList();
        }

        public void SetTestsToUser(int userId)
        {
            
        }
    }
}
