using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityExplorer.DtoLayer.TicketMapper
{
    public class CreateTicketDto
    {
        public string EventName { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int EventID { get; set; }
       
    }
}
