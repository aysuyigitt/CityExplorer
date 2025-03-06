using CityExplorer.EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityExplorer.BusinessLayer.Service
{
    public interface ICityDetailService : IGenericService<CityDetail>
    {
        public List<CityDetail> TGetCityDetailByCityId(int id);
    }
}
