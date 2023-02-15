using TestTaskOSKI.DTO.ModelViewsObjects;

namespace TestTaskOSKI.Services.ServicesInterfaces
{
    public interface ILoginService
    {
        public int NewUser(UserDTO user);
    }
}
