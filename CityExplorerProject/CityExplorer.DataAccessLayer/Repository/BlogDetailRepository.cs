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
    public class BlogDetailRepository : GenericRepository<BlogDetail>, IBlogDetailRepository
    {
        public BlogDetailRepository(CityExplorerContext context) : base(context)
        {
        }

        public List<BlogDetail> GetBlogDetailByBlogId(int id)
        {
            CityExplorerContext context = new CityExplorerContext();

            var values = context.BlogDetails.Include(x => x.Blog).Where(y => y.BlogID == id).ToList();
            return values;
        }
    }
}
