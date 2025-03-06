using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CityExplorer.EntitiesLayer.Entities
{
    public class BlogDetail
    {
        public int BlogDetailID {  get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string SectionTitle { get; set; }
        public string Description1 { get; set; } 
        public string Description2 { get; set; } 
        public string Description3 { get; set; }

        public int BlogID { get; set; }

        [JsonIgnore]
        public Blog Blog { get; set; }


    }
}
