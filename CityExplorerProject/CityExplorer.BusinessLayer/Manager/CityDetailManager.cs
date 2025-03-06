using CityExplorer.BusinessLayer.Service;
using CityExplorer.DataAccessLayer.Abstract;
using CityExplorer.DataAccessLayer.Repository;
using CityExplorer.EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityExplorer.BusinessLayer.Manager
{
    public class CityDetailManager : ICityDetailService
    {
        private readonly ICityDetailRepository _cityDetailRepository;

        public CityDetailManager(ICityDetailRepository cityDetailRepository)
        {
            _cityDetailRepository = cityDetailRepository;
        }

        public async Task TCreateAsync(CityDetail entity)
        {
            await _cityDetailRepository.CreateAsync(entity);    
        }

        public Task<List<CityDetail>> TGetAllAsync()
        {
           return _cityDetailRepository.GetAllAsync();
        }

        public Task<CityDetail> TGetByIdAsync(int id)
        {
            return _cityDetailRepository.GetByIdAsync(id);  
        }

        public List<CityDetail> TGetCityDetailByCityId(int id)
        {
            return _cityDetailRepository.GetCityDetailByCityId(id);    
        }

        public async Task TRemoveAsync(CityDetail entity)
        {
           await _cityDetailRepository.RemoveAsync(entity);  
        }

        public async Task TUpdateAsync(CityDetail entity)
        {
            await _cityDetailRepository.UpdateAsync(entity);
        }
    }
}







