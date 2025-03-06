using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityExplorer.DtoLayer.CityDetailMapper
{
    public class UpdateCityDetailDto
    {
        public int CityDetailID { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }         // Şehir hakkında genel açıklama
        public long Population { get; set; }            // Nüfus bilgisi
        public double Area { get; set; }                // Yüzölçümü (km²)
        public string Climate { get; set; }             // İklim tipi
        public string Culture { get; set; }             // Kültürel bilgiler

        public int CityID { get; set; }
    }
}
