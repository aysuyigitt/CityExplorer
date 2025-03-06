using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityExplorer.EntitiesLayer.Entities
{
    public class Ticket
    {
        public int TicketID { get; set; }   
        public string EventName {  get; set; }
        public DateTime PurchaseDate { get; set; }
        public int EventID { get; set; }
        public Event Event { get; set; }
    }
}
