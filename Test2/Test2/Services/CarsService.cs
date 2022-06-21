using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Test2.Models;

namespace Test2.Services
{
    public class CarsService : ICarsService
    {
        private readonly S22455Context _context;

        public CarsService(S22455Context context)
        {
            _context = context;
        }
        //I'm calling inspection service because it is called in such way in a task
        public async Task<object> ChangeCarAssignedToService(int idCar, int idInspection)
        {
            var car = await _context.Car.Where(c=> c.IdCar == idCar).SingleOrDefaultAsync();
            if (Validate(car))
                return "Car not found!";
            var service = await _context.Inspection.Where(i => i.IdInspection == idInspection).SingleOrDefaultAsync();
            if (Validate(service))
                return "Inspection not found!";
            if (service.IdCar == idCar)
                return "This car is already assigned to this inspection!";
            if (DateTime.Now >= service.InspectionDate)
                return "Inspection already started!";
            

            service.IdCar = car.IdCar;
            _context.Update(service);
            await _context.SaveChangesAsync();

            return $"Succesfully updated! New car: {car.Name}, {car.ProductionYear}";
        }
        private static bool Validate(Car car) {
            return car == null;
        }
        private static bool Validate(Inspection inspection)
        {
            return inspection == null;
        }
    }
}
