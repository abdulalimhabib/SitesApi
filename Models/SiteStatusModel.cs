using System;

namespace SitesApi.Models
{
    public class SiteStatusModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string VehicleStatus { get; set; }
        public string PclStatus { get; set; }
        public string HealthStatus { get; set; }
        public string OnlineStatus { get; set; }
        public string StationStatus { get; set; }
        public DateTimeOffset LastUpdateTime { get; set; }
    }
}