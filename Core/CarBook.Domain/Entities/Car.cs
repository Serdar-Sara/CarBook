using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class Car
    {
        public int CarID { get; set; }
        public int BrandID { get; set; }  //BrandID is a foreign key that links each car to a specific Brand.

        public Brand Brand { get; set; } //Brand navigation property allows access to the related Brand object.

        public string Model { get; set; }

        public string CoverImageUrl { get; set; }

        public int Km { get; set; }

        public string Transmission { get; set; }

        public byte Seat { get; set; }

        public byte Luggage { get; set; }

        public string Fuel { get; set; }

        public string BigImageUrl { get; set; }

        public List<CarFeature> CarFeatures { get; set; }  // write it into both of car and feature classes
        public List<CarDescription> CarDesccriptions { get; set; }

        public List<CarPricing> CarPricings { get; set; }



    }
}
