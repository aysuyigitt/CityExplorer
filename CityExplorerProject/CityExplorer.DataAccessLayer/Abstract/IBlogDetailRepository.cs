using CityExplorer.EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityExplorer.DataAccessLayer.Abstract
{
    public interface IBlogDetailRepository : IGenericRepository<BlogDetail>
    {
        public List<BlogDetail> GetBlogDetailByBlogId(int id);
    }
}
