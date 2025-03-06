using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityExplorer.DtoLayer.TicketMapper
{
    public class UpdateTicketDto
    {
        public int TicketID { get; set; }
        public string EventName { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int EventID { get; set; }
    }
}
