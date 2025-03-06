﻿using CityExplorer.EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityExplorer.BusinessLayer.Service
{
    public interface ITicketService : IGenericService<Ticket>
    {
        Task TBuyTicketAsync(Ticket ticket);
    }
}
