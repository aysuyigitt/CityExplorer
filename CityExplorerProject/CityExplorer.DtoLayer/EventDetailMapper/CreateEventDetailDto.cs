using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityExplorer.DtoLayer.EventDetailMapper
{
    public class CreateEventDetailDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public string Location { get; set; }
        public string ImageUrl { get; set; }
        public string Stil1 { get; set; }
        public string Stil2 { get; set; }
        public string Stil3 { get; set; }
        public int EventID { get; set; }

    }
}
