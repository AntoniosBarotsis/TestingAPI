using System.Threading.Tasks;

namespace src.Services
{
    public interface IMyDependency
    {
        Task<string> GetDataFromDatabaseAsync();
    }
}