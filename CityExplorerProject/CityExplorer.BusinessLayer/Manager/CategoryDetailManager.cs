using CityExplorer.BusinessLayer.Service;
using CityExplorer.DataAccessLayer.Abstract;
using CityExplorer.EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityExplorer.BusinessLayer.Manager
{
    public class CategoryDetailManager : ICategoryDetailService
    {
        private readonly ICategoryDetailRepository _categoryDetailRepositoy;

        public CategoryDetailManager(ICategoryDetailRepository categoryDetailRepositoy)
        {
            _categoryDetailRepositoy = categoryDetailRepositoy;
        }

        public async Task TCreateAsync(CategoryDetail entity)
        {
            await _categoryDetailRepositoy.CreateAsync(entity);   
        }

        public Task<List<CategoryDetail>> TGetAllAsync()
        {
            return _categoryDetailRepositoy.GetAllAsync();  
        }

        public Task<CategoryDetail> TGetByIdAsync(int id)
        {
            return _categoryDetailRepositoy.GetByIdAsync(id);   
        }

        public List<CategoryDetail> TGetCategoryDetailByCityId(int id)
        {
            return _categoryDetailRepositoy.GetCategoryDetailByCityId(id); 
        }

        public async Task TRemoveAsync(CategoryDetail entity)
        {
            await _categoryDetailRepositoy.RemoveAsync(entity); 
        }

        public async Task TUpdateAsync(CategoryDetail entity)
        {
            await _categoryDetailRepositoy.UpdateAsync(entity); 
        }
    }
}
