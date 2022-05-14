using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEVTRACK.API.Models
{
    public class AddPackageInputModel
    {
        public string  Status { get; set; } = string.Empty;
        public bool Delivety { get; set; }       
    }
}