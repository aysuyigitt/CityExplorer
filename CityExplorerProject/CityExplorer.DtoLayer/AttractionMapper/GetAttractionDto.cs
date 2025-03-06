using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityExplorer.DtoLayer.AttractionMapper
{
    public class GetAttractionDto
    {
        public int AttractionID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryID { get; set; }
        public int CityID { get; set; }
    }
}
