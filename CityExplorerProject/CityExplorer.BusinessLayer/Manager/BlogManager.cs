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
    public class BlogManager : IBlogService
    {
        private readonly IBlogRepository _blogRepository;

        public BlogManager(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public async Task TCreateAsync(Blog entity)
        {
           await  _blogRepository.CreateAsync(entity);    
        }

        public Task<List<Blog>> TGetAllAsync()
        {
            return _blogRepository.GetAllAsync();   
        }

        public Task<Blog> TGetByIdAsync(int id)
        {
            return _blogRepository.GetByIdAsync(id);    
        }

        public async Task TRemoveAsync(Blog entity)
        {
            await _blogRepository.RemoveAsync(entity);  
        }

        public async Task TUpdateAsync(Blog entity)
        {
           await _blogRepository.UpdateAsync(entity);   
        }
    }
}
