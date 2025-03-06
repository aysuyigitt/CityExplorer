using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityExplorer.EntitiesLayer.Entities
{
    public class Testimonial
    {
        public int TestimonialID { get; set; }      
        public string UserName { get; set; }        
        public string Message { get; set; }         
        public string ImageUrl { get; set; }        
    }
}
