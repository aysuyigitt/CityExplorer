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
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaRepository _mediaRepository;

        public SocialMediaManager(ISocialMediaRepository mediaRepository)
        {
            _mediaRepository = mediaRepository;
        }

        public async Task TCreateAsync(SocialMedia entity)
        {
            await _mediaRepository.CreateAsync(entity);
        }

        public Task<List<SocialMedia>> TGetAllAsync()
        {
           return _mediaRepository.GetAllAsync();   
        }

        public Task<SocialMedia> TGetByIdAsync(int id)
        {
           return _mediaRepository.GetByIdAsync(id);    
        }

        public async Task TRemoveAsync(SocialMedia entity)
        {
            await _mediaRepository.RemoveAsync(entity);
        }

        public async Task TUpdateAsync(SocialMedia entity)
        {
          await _mediaRepository.UpdateAsync(entity);   
        }
    }
}
