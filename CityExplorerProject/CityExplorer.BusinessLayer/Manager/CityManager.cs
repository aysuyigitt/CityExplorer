using CityExplorer.BusinessLayer.Service;
using CityExplorer.DataAccessLayer.Abstract;
using CityExplorer.DataAccessLayer.Repository;
using CityExplorer.EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CityExplorer.BusinessLayer.Manager
{
    public class CityManager : ICityService
    {
        private readonly ICityRepository _cityRepository;

        public CityManager(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public async Task TCreateAsync(City entity)
        {
            await _cityRepository.CreateAsync(entity);  
        }

        public Task<List<City>> TGetAllAsync()
        {
            return _cityRepository.GetAllAsync();   
        }

        public Task<City> TGetByIdAsync(int id)
        {
            return _cityRepository.GetByIdAsync(id);    
        }

        public async Task TRemoveAsync(City entity)
        {
            await _cityRepository.RemoveAsync(entity);      
        }

        public async Task TUpdateAsync(City entity)
        {
            await _cityRepository.UpdateAsync(entity);  
        }
    }
}
