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
    public class AttractionManager : IAttractionService
    {
        private readonly IAttractionRepository _attractionRepository;

        public AttractionManager(IAttractionRepository attractionRepository)
        {
            _attractionRepository = attractionRepository;
        }

        public async Task TCreateAsync(Attraction entity)
        {
            await _attractionRepository.CreateAsync(entity); 
        }

        public Task<List<Attraction>> TGetAllAsync()
        {
            return _attractionRepository.GetAllAsync(); 
        }

        public Task<Attraction> TGetByIdAsync(int id)
        {
            return _attractionRepository.GetByIdAsync(id); 
        }

        public async Task TRemoveAsync(Attraction entity)
        {
           await _attractionRepository.RemoveAsync(entity);  
        }

        public async Task TUpdateAsync(Attraction entity)
        {
           await _attractionRepository.UpdateAsync(entity); 
        }
    }
}
