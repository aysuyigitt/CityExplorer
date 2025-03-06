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
    public class EventManager : IEventService
    { 
        private readonly IEventRepository _eventRepository;

        public EventManager(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public async Task TCreateAsync(Event entity)
        {
           await _eventRepository.CreateAsync(entity);  
        }

        public Task<List<Event>> TGetAllAsync()
        {
            return _eventRepository.GetAllAsync();  
        }

        public Task<Event> TGetByIdAsync(int id)
        {
            return _eventRepository.GetByIdAsync(id);   
        }

        public async Task TRemoveAsync(Event entity)
        {
            await _eventRepository.RemoveAsync(entity); 
        }

        public async Task TUpdateAsync(Event entity)
        {
           await _eventRepository.UpdateAsync(entity);  
        }
    }
}
