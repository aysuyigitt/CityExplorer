using CityExplorer.EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityExplorer.DataAccessLayer.Abstract
{
    public interface ICategoryDetailRepository : IGenericRepository<CategoryDetail>
    {
        public List<CategoryDetail> GetCategoryDetailByCityId(int id);
    }
}
