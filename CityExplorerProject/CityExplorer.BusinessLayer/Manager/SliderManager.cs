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
    public class SliderManager : ISliderService
    {
        private readonly ISliderRepository _sliderRepository;

        public SliderManager(ISliderRepository sliderRepository)
        {
            _sliderRepository = sliderRepository;
        }

        public async Task TCreateAsync(Slider entity)
        {
           await _sliderRepository.CreateAsync(entity); 
        }

        public Task<List<Slider>> TGetAllAsync()
        {
           return _sliderRepository.GetAllAsync();  
        }

        public Task<Slider> TGetByIdAsync(int id)
        {
            return _sliderRepository.GetByIdAsync(id);
        }

        public async Task TRemoveAsync(Slider entity)
        {
            await _sliderRepository.RemoveAsync(entity);    
        }

        public async Task TUpdateAsync(Slider entity)
        {
            await _sliderRepository.UpdateAsync(entity);    
        }
    }
}
