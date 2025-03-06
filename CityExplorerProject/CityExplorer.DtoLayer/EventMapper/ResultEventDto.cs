using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityExplorer.DtoLayer.EventMapper
{
    public class ResultEventDto
    {
        public int EventID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public string Location { get; set; }
        public string ImageUrl { get; set; }
        public int AttractionID { get; set; }
    }
}
