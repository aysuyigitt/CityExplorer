using CityExplorer.DataAccessLayer.Abstract;
using CityExplorer.DataAccessLayer.Concrete;
using CityExplorer.EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityExplorer.DataAccessLayer.Repository
{
    public class AboutRepository : GenericRepository<About>, IAboutRepository
    {
        public AboutRepository(CityExplorerContext context) : base(context)
        {
        }
    }
}
