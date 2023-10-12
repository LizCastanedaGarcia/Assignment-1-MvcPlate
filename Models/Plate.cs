using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcPlate.Models
{
    public class Plate
    {
        [Display(Name = "ID Item")]
        public int Id { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Stock Date")]
        [DataType(DataType.Date)]
        public DateTime StockDate { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Origin Country")]
        public string Origen { get; set; }

        [Display(Name = "Color")]
        public string Color { get; set; }

        [Display(Name = "Size")]
        [Column(TypeName = "decimal(2, 2)")]
        public decimal Size { get; set; }

        [Display(Name = "Price CAD")]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }


        [Display(Name = "Ratin 1-5")]
        public decimal Rating { get; set; }

    }
}



    