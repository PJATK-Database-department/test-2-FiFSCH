using System.Threading.Tasks;
using Test2.Models;
namespace Test2.Services
{
    public interface IInspectionsService
    {
        public Task<object> GetInspection(int idInspection);
    }
}
