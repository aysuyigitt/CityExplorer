using CityExplorer.EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CityExplorer.DataAccessLayer.Abstract
{
    public interface ITicketRepository : IGenericRepository<Ticket>
    {
        Task BuyTicketAsync(Ticket ticket);

    }
}
