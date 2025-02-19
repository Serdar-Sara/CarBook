using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class CarDescription  // descriptionlar uzun olacağımiçin ayri bir tabloda tututldu
    {
        public int CarDescriptionID { get; set; }
        public string Details { get; set; }

        // which car  has this description 
        public int CarID { get; set; }
        public Car Car { get; set; }


    }
}
