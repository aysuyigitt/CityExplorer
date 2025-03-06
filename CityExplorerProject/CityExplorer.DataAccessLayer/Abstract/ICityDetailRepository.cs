using CityExplorer.EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CityExplorer.DataAccessLayer.Abstract
{
    public interface ICityDetailRepository : IGenericRepository<CityDetail>
    {
        public List<CityDetail> GetCityDetailByCityId(int id);
    }
}
