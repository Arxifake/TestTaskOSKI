using TestTaskOSKI.DataAccess.DBContext;
using TestTaskOSKI.DataAccess.Interfaces;
using TestTaskOSKI.DataAccess.Models;

namespace TestTaskOSKI.DataAccess.Repositories
{
    public class Users : IUsers
    {
        private readonly IServiceScopeFactory _scopeFactory;
        public Users(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
        }
        public int NewUser(User user)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<TestAppContext>();
                db.Users.Add(user);
                db.SaveChanges();
                return user.Id;
            }
        }
    }
}
