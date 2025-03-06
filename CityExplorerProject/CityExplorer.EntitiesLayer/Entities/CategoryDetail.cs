using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CityExplorer.EntitiesLayer.Entities
{
    public class CategoryDetail
    {
        public int CategoryDetailID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl {  get; set; }   
        public string Rating {  get; set; } 
        public int CategoryID {  get; set; }

        [JsonIgnore]
        public Category Category { get; set; }  


    }
}
