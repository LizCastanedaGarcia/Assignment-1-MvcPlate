using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcPlate.Models
{
    public class PlateColorViewModel
    {
        public List<Plate> Plates { get; set; }
        public SelectList Color { get; set; }
        public string PlateColor { get; set; }
        public string SearchString { get; set; }
    }
}