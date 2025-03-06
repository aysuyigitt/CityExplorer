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
    public class AttractionRepository : GenericRepository<Attraction>, IAttractionRepository
    {
        public AttractionRepository(CityExplorerContext context) : base(context)
        {
        }

        public List<Attraction> GetAttractionsWithCity()
        {
            using var context = new CityExplorerContext();
            var values = context.Attractions.Include(x => x.City).ToList();
            return values;
        }
    }
}
