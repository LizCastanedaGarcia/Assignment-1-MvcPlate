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

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Stock Date")]
        [DataType(DataType.Date)]
        public DateTime StockDate { get; set; }

        [Required]
        [StringLength(160, MinimumLength = 15)]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Origin Country")]
        [StringLength(40, MinimumLength = 3)]
        public string Origen { get; set; }

        [Required]
        [Display(Name = "Color")]
        [StringLength(50, MinimumLength = 4)]
        public string Color { get; set; }

        [Required]
        [Display(Name = "Size")]
        [Column(TypeName = "decimal(2, 2)")]
        public decimal Size { get; set; }

        [Required]
        [Display(Name = "Price CAD")]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Rating 1-5")]
        [Range (1,5)]
        public decimal Rating { get; set; }

    }
}



    