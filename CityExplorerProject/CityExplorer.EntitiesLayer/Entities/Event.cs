using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityExplorer.EntitiesLayer.Entities
{
    public class Event
    {
        public int EventID { get; set; }               
        public string Name { get; set; }               
        public string Description { get; set; }        
        public DateTime StartDate { get; set; }        
        public string Location { get; set; }          
        public string ImageUrl { get; set; }          
        public int AttractionID { get; set; }         
        public Attraction Attraction { get; set; }

        public List<EventDetail> EventDetails { get; set; }
        public List<Ticket> Tickets { get; set; }   
    }
}
