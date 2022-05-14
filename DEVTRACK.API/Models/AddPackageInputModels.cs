using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEVTRACK.API.Models
{
    public class AddPackageInputModels
    {
        public string Title { get; set; }  = string.Empty;
        public double Weight { get; set; }
    }
}