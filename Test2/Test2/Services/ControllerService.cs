using Test2.Models;

namespace Test2.Services
{
    public class ControllerService : IControllerService
    {
        private readonly S22455Context _context;

        public ControllerService(S22455Context context)
        {
            _context = context;
        }
    }
}
