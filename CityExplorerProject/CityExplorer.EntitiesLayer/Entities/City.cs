using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityExplorer.EntitiesLayer.Entities
{
    public class City
    {
        public int CityID {  get; set; }
        public string Name {  get; set; }   
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public List<Attraction> Attractions {  get; set; }
        public List<CityDetail> CityDetails { get; set; }


    }
}
