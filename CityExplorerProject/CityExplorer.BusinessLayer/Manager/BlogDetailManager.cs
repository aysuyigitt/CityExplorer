using CityExplorer.BusinessLayer.Service;
using CityExplorer.DataAccessLayer.Abstract;
using CityExplorer.EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CityExplorer.BusinessLayer.Manager
{
    public class BlogDetailManager : IBlogDetailService
    {
        private readonly IBlogDetailRepository _blogDetailRepository;

        public BlogDetailManager(IBlogDetailRepository blogDetailRepository)
        {
            _blogDetailRepository = blogDetailRepository;
        }

        public async Task TCreateAsync(BlogDetail entity)
        {
           await _blogDetailRepository.CreateAsync(entity);
        }

        public Task<List<BlogDetail>> TGetAllAsync()
        {
            return _blogDetailRepository.GetAllAsync();
        }

        public List<BlogDetail> TGetBlogDetailByBlogId(int id)
        {
            return _blogDetailRepository.GetBlogDetailByBlogId(id);
        }

        public Task<BlogDetail> TGetByIdAsync(int id)
        {
           return _blogDetailRepository.GetByIdAsync(id);
        }

        public async Task TRemoveAsync(BlogDetail entity)
        {
           await _blogDetailRepository.RemoveAsync(entity); 
        }

        public async Task TUpdateAsync(BlogDetail entity)
        {
           await _blogDetailRepository.UpdateAsync(entity);  
        }
    }
}
