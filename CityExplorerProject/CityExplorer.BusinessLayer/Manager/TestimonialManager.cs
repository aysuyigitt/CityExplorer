using CityExplorer.BusinessLayer.Service;
using CityExplorer.DataAccessLayer.Abstract;
using CityExplorer.EntitiesLayer.Entities;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityExplorer.BusinessLayer.Manager
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialRepository _testimonialRepository;

        public TestimonialManager(ITestimonialRepository testimonialRepository)
        {
            _testimonialRepository = testimonialRepository;
        }

        public async Task TCreateAsync(Testimonial entity)
        {
            await _testimonialRepository.CreateAsync(entity);   
        }

        public Task<List<Testimonial>> TGetAllAsync()
        {
            return _testimonialRepository.GetAllAsync();    
        }

        public Task<Testimonial> TGetByIdAsync(int id)
        {
           return _testimonialRepository.GetByIdAsync(id);  
        }

        public async Task TRemoveAsync(Testimonial entity)
        {
            await _testimonialRepository.RemoveAsync(entity);   
        }

        public async Task TUpdateAsync(Testimonial entity)
        {
            await _testimonialRepository.UpdateAsync(entity);   
        }
    }
}
