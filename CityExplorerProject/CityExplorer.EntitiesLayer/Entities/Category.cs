using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityExplorer.EntitiesLayer.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl {  get; set; }   

        public List<Attraction> Attractions { get; set; }
        public List<CategoryDetail> CategoryDetails { get; set; }
    }
}
