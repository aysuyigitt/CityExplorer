using CityExplorer.EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityExplorer.DataAccessLayer.Abstract
{
    public interface IEventDetailRepository : IGenericRepository<EventDetail>
    {
        public List<EventDetail> GetEventDetailByEventId(int id);
    }
}
