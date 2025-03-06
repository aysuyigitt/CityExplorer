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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryRepositoy _categoryRepositoy;

        public CategoryManager(ICategoryRepositoy categoryRepositoy)
        {
            _categoryRepositoy = categoryRepositoy;
        }

        public async Task TCreateAsync(Category entity)
        {
           await _categoryRepositoy.CreateAsync(entity);  
        }

        public Task<List<Category>> TGetAllAsync()
        {
            return _categoryRepositoy.GetAllAsync();
        }

        public Task<Category> TGetByIdAsync(int id)
        {
           return _categoryRepositoy.GetByIdAsync(id);  
        }

        public async Task TRemoveAsync(Category entity)
        {
           await _categoryRepositoy.RemoveAsync(entity);
        }

        public async  Task TUpdateAsync(Category entity)
        {
            await _categoryRepositoy.UpdateAsync(entity);   
        }
    }
}
