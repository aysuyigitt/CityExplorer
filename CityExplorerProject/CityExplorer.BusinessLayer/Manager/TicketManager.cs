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
    public class TicketManager : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;

        public TicketManager(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public async Task TBuyTicketAsync(Ticket ticket)
        {
            // Bilet alım işlemini asenkron olarak yap
            await _ticketRepository.BuyTicketAsync(ticket);  // Repository'yi asenkron hale getirdik
        }

        public async Task TCreateAsync(Ticket entity)
        {
            await _ticketRepository.CreateAsync(entity);    
        }

        public Task<List<Ticket>> TGetAllAsync()
        {
           return _ticketRepository.GetAllAsync();
        }

        public Task<Ticket> TGetByIdAsync(int id)
        {
           return _ticketRepository.GetByIdAsync(id);
        }

        public async Task TRemoveAsync(Ticket entity)
        {
          await _ticketRepository.RemoveAsync(entity);    
        }

        public async Task TUpdateAsync(Ticket entity)
        {
           await _ticketRepository.UpdateAsync(entity);  
        }
    }
}
