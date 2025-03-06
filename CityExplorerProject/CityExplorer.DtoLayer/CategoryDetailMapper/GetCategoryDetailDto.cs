using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityExplorer.DtoLayer.CategoryDetailMapper
{
    public class GetCategoryDetailDto
    {
        public int CategoryDetailID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Rating { get; set; }

        public int CategoryID { get; set; }
    }
}
