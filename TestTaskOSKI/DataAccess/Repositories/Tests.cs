using System.Linq;
using TestTaskOSKI.DataAccess.DBContext;
using TestTaskOSKI.DataAccess.Interfaces;
using TestTaskOSKI.DataAccess.Models;

namespace TestTaskOSKI.DataAccess.Repositories
{
    public class Tests : ITests
    {
        private const int testsForUser = 10;
        private Random random = new Random();
        private readonly IServiceScopeFactory _scopeFactory;
        public Tests(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
        }

        public Test GetTest(int id)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<TestAppContext>();
                return db.Tests.First(x=>x.Id==id);
            }
        }

        public List<Test> GetTests(int userId)
        {
            using(var scope = _scopeFactory.CreateScope()) 
            {
                var db = scope.ServiceProvider.GetRequiredService<TestAppContext>();
                var testList = new List<Test>();
                var testsForUser = db.TestUser.Where(tu => tu.UserId == userId);
                testList = db.Tests.Where(t => testsForUser.Any(g => g.TestId == t.Id)).ToList();
                return testList;
            }
            
        }

        public void SetTestsToUsers(int userId)
        {
            using(var scope = _scopeFactory.CreateScope()) 
            {
                var db = scope.ServiceProvider.GetRequiredService<TestAppContext>();
                var testsCount = db.Tests.Count();
                var idArr = new List<int>();
                if(testsCount > testsForUser)
                {
                    while (idArr.Count < testsForUser) 
                    {
                        var test = db.Tests.First(x => x.Id == random.Next(1,testsCount+1));
                        if (!idArr.Contains(test.Id))
                            {
                                idArr.Add(test.Id);
                            }
                    }
                    foreach(int id in idArr) 
                    {
                        db.TestUser.Add(new TestUser() { TestId= id, UserId=userId });
                    }
                }
                else 
                {
                    for(int i = 1; i <= testsCount; i++) 
                    {
                        db.TestUser.Add(new TestUser() {TestId= i,UserId=userId});
                    }
                    db.SaveChanges();
                }
                
            }
        }
    }
}
