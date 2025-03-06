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
    public class CityDetailRepository : GenericRepository<CityDetail>, ICityDetailRepository
    {
        public CityDetailRepository(CityExplorerContext context) : base(context)
        {

        }

        public List<CityDetail> GetCityDetailByCityId(int id)
        {
            CityExplorerContext context = new CityExplorerContext();

            var values= context.CityDetails.Include(x => x.City).Where(y => y.CityID == id).ToList();
            return values;
        }
    }
}
