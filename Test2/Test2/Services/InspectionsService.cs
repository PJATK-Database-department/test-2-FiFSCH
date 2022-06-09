using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test2.Models;

namespace Test2.Services
{
    public class InspectionsService : IInspectionsService
    {
        private readonly S22455Context _context;

        public InspectionsService(S22455Context context)
        {
            _context = context;
        }

        public async Task<object> GetInspection(int idInspection)
        {
            var inspection = await _context.Inspection.Where(i=> i.IdInspection == idInspection).SingleOrDefaultAsync();
            if (inspection == null)
                return null;
            var car = await (from c in _context.Car
                             join i in _context.Inspection on c.IdCar equals i.IdCar
                             where i.IdInspection == idInspection
                             select new
                             {
                                 Name = c.Name,
                                 ProductionYear = c.ProductionYear
                             }).ToListAsync();
            var services = await (from std in _context.ServiceTypeDict
                                  join stdi in _context.ServiceTypeDictInspection on std.IdServiceType equals stdi.IdServiceType
                                  where stdi.IdInspection == idInspection
                                  select new
                                  {
                                      ServiceType = std.ServiceType,
                                      Price = std.Price,
                                      Comments = stdi.Comments
                                  }).ToListAsync();
            var mechanic = await (from m in _context.Mechanic
                                  join i in _context.Inspection on m.IdMechanic equals i.IdMechanic
                                  where i.IdInspection == idInspection
                                  select new
                                  {
                                      FirstName = m.FirstName,
                                      LastName = m.LastName,
                                      Services = new List<object> { services }
                                  }).ToListAsync();
            var result = new
            {
                InspectionDate = inspection.InspectionDate,
                Comment = inspection.Comment,
                Car = new List<object> { car },
                Mechanic = new List<object> { mechanic }
            };
            return result;
        }
    }
}
