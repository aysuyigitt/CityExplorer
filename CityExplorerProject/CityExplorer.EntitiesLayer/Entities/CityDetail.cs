using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CityExplorer.EntitiesLayer.Entities
{
    public class CityDetail
    {
        public int CityDetailID { get; set; }
        public string Name {  get; set; }   
        public string ImageUrl {  get; set; }   
        public string Description { get; set; }         // Şehir hakkında genel açıklama
        public long Population { get; set; }            // Nüfus bilgisi
        public double Area { get; set; }                // Yüzölçümü (km²)
        public string Climate { get; set; }             // İklim tipi
        public string Culture { get; set; }
        public int CityID { get; set; }

        [JsonIgnore] // Döngüyü kırar
        public City City { get; set; }

        
       
    
    }
}

