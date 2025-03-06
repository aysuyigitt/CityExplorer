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
    public class AboutManager : IAboutService
    {
        private readonly IAboutRepository _aboutRepository;

        public AboutManager(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }

        public async Task TCreateAsync(About entity)
        {
           await _aboutRepository.CreateAsync(entity);
        }

        public Task<List<About>> TGetAllAsync()
        {
           return  _aboutRepository.GetAllAsync();
        }

        public Task<About> TGetByIdAsync(int id)
        {
           return _aboutRepository.GetByIdAsync(id);    
        }

        public async Task TRemoveAsync(About entity)
        {
            await _aboutRepository.RemoveAsync(entity);   
        }

        public async Task TUpdateAsync(About entity)
        {
            await _aboutRepository.UpdateAsync(entity); 
        }
    }
}
