using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Entities.Api
{
    public class Package
    {
        public Package (string title,double weight)
        {
            this.Title = title;
            this.Weight = weight;
        }
        public void AddUpdate(string status, bool delivery)
        {
            var update = new PackageUpdate(status, Id);
            Updates.Add(update);
            if(delivery){
                this.Delivery = true;
            }
        }

        public int Id { get;private  set; }
        public string Code { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;    
        public double Weight { get; set; }
        public bool Delivery { get; set; }
        public DateTime PostedAt { get; set; }
        public List<PackageUpdate> Updates { get; set; } = new List<PackageUpdate>();


    }
}