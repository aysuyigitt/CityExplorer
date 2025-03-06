using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityExplorer.DtoLayer.TestimonialMapper
{
    public class GetTestimonialDto
    {
        public int TestimonialID { get; set; }
        public string UserName { get; set; }
        public string Message { get; set; }
        public string ImageUrl { get; set; }
    }
}
