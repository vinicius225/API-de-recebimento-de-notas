using Entities.Api;

namespace DEVTRACK.API.Persistence
{
    public class DevTrackContext
    {

        public List<Package> Packages { get; set; } = new List<Package>();
    }
}