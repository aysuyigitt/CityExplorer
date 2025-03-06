using CityExplorer.DataAccessLayer.Abstract;
using CityExplorer.DataAccessLayer.Concrete;
using CityExplorer.EntitiesLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityExplorer.DataAccessLayer.Repository
{
    public class EventDetailRepository : GenericRepository<EventDetail>, IEventDetailRepository
    {
        public EventDetailRepository(CityExplorerContext context) : base(context)
        {
        }

        public List<EventDetail> GetEventDetailByEventId(int id)
        {
            CityExplorerContext _context = new CityExplorerContext();

            var value = _context.EventDetails.Include(x=>x.Event).Where(y=>y.EventID == id).ToList();
            return value;
        }
    }
}
