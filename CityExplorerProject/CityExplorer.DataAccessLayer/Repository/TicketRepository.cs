using CityExplorer.DataAccessLayer.Abstract;
using CityExplorer.DataAccessLayer.Concrete;
using CityExplorer.EntitiesLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityExplorer.DataAccessLayer.Repository
{
    public class TicketRepository : GenericRepository<Ticket>, ITicketRepository
    {
        private readonly CityExplorerContext _context;

        public TicketRepository(CityExplorerContext context) : base(context)
        {
            _context = context;
        }

        public async Task BuyTicketAsync(Ticket ticket)
        {
            if (ticket == null)
                throw new ArgumentNullException(nameof(ticket));

            // Etkinliği asenkron kontrol et
            var existingEvent = await _context.Events.FirstOrDefaultAsync(e => e.EventID == ticket.EventID);
            if (existingEvent == null)
                throw new Exception("Seçilen etkinlik bulunamadı!");

            // Bileti asenkron şekilde ekle
            _context.Tickets.Add(ticket);

            // Asenkron işlemle kaydet
            await _context.SaveChangesAsync(); // Asenkron kaydetme
        }

    }
}
    

