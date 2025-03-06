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
    public class EventDetailManager : IEventDetailService
    {
        private readonly IEventDetailRepository _eventDetailRepository;

        public EventDetailManager(IEventDetailRepository eventDetailRepository)
        {
            _eventDetailRepository = eventDetailRepository;
        }

        public async Task TCreateAsync(EventDetail entity)
        {
           await _eventDetailRepository.CreateAsync(entity);    
        }

        public Task<List<EventDetail>> TGetAllAsync()
        {
           return _eventDetailRepository.GetAllAsync(); 
        }

        public Task<EventDetail> TGetByIdAsync(int id)
        {
           return _eventDetailRepository.GetByIdAsync(id);  
        }

        public List<EventDetail> TGetEventDetailByEventId(int id)
        {
           return _eventDetailRepository.GetEventDetailByEventId(id);  
        }

        public async Task TRemoveAsync(EventDetail entity)
        {
            await _eventDetailRepository.RemoveAsync(entity);   
        }

        public async Task TUpdateAsync(EventDetail entity)
        {
           await _eventDetailRepository.UpdateAsync(entity);
        }
    }
}
