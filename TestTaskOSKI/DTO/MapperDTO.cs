using AutoMapper;
using TestTaskOSKI.DataAccess.Models;
using TestTaskOSKI.DTO.ModelViewsObjects;

namespace TestTaskOSKI.DTO
{
    public class MapperDTO:Profile
    {
        public MapperDTO() 
        {
            CreateMap<TestDTO,Test>().ReverseMap();
            CreateMap<QuestionDTO, Question>().ReverseMap();
            CreateMap<AnswerDTO, Answer>().ReverseMap();
            CreateMap<UserDTO, User>().ReverseMap();

        }
    }
}
