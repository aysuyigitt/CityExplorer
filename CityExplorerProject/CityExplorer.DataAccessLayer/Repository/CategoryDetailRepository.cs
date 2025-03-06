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
    public class CategoryDetailRepository : GenericRepository<CategoryDetail>, ICategoryDetailRepository
    {
        public CategoryDetailRepository(CityExplorerContext context) : base(context)
        {
        }

        public List<CategoryDetail> GetCategoryDetailByCityId(int id)
        {
            CityExplorerContext context = new CityExplorerContext();

            var values = context.CategoryDetails.Include(x=>x.Category).Where(y=>y.CategoryID==id).ToList();
            return values;

        }
    }
}
