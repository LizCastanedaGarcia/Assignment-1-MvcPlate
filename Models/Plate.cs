using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcPlate.Models
{
    public class Plate
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime StockDate { get; set; }
        
        public string Description { get; set; }
        public string Origen { get; set; }
        public string Color { get; set; }
        public decimal Size { get; set; }
        
        public decimal Price { get; set; }

        public decimal Rating { get; set; }

    }
}



    