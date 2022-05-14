using System;


namespace Entities.Api
{
    public class PackageUpdate
    {
        public int Id { get; private set; }
        public int PackageId { get;private set; }
        public string Status { get; private set; } = string.Empty;
        public DateTime UpdateDate { get; private set; }

        public PackageUpdate(string status, int id){
            this.Status = status;
            this.Id = id;
            this.UpdateDate = DateTime.Now;
        }
    }
}