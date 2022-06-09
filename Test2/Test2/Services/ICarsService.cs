using System.Threading.Tasks;
using Test2.Models;
namespace Test2.Services
{
    public interface ICarsService
    {
        public Task<object> ChangeCarAssignedToService(int idCar, int idInspection);
    }
}
