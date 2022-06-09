using Test2.Models;

namespace Test2.Services
{
    public class Controller2Service : IController2Service
    {
        private readonly S22455Context _context;

        public Controller2Service(S22455Context context)
        {
            _context = context;
        }
    }
}
