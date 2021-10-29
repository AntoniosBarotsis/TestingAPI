using System.Threading.Tasks;

namespace src.Services
{
    public class MyDependency : IMyDependency
    {
        public Task<string> GetDataFromDatabaseAsync()
        {
            return Task.FromResult("Hello From MyDependency!");
        }
    }
}