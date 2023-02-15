using AutoMapper;
using TestTaskOSKI.DataAccess.Interfaces;
using TestTaskOSKI.DataAccess.Models;
using TestTaskOSKI.DTO.ModelViewsObjects;
using TestTaskOSKI.Services.ServicesInterfaces;

namespace TestTaskOSKI.Services.TestsServices
{
    public class LoginService : ILoginService
    {
        private readonly IMapper _mapper;
        private readonly IUsers _usersRepo;
        private readonly ITests _testsRepo;

        public LoginService(IUsers usersRepo, IMapper mapper, ITests testsRepo)
        {
            _mapper = mapper;
            _usersRepo = usersRepo;
            _testsRepo = testsRepo;
        }

        public int NewUser(UserDTO user)
        {
            var userId = _usersRepo.NewUser(_mapper.Map<User>(user));
            _testsRepo.SetTestsToUsers(userId);
            return userId;
        }
    }
}
