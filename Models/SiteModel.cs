using System;

namespace SitesApi.Models
{
    public class SiteModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // public string Abbreviation { get; set; }
        // public string SiteCode { get; set; }
        public string StateCode { get; set; }
        // public int DirectionId { get; set; }
        // public int PhaseTypeId { get; set; }
        // public int StatusTypeId { get; set; }
        // public int TimeZoneId { get; set; }
        // public string AxleConfiguration { get; set; }
        // public double Latitude { get; set; }
        // public double Longitude { get; set; }
        // public string Address { get; set; }
        // public string OfficerPhone { get; set; }
        // public string Fax { get; set; }
        // public int NextGenSiteId { get; set; }
        // public string RouterModel { get; set; }
        // public string RouterIP { get; set; }
        // public string VendorInterface { get; set; }
        // public int IcnTimeout { get; set; }
        // public bool IcnExit { get; set; }
        // public int CompTimeout { get; set; }
        // public bool CompExit { get; set; }
        // public bool CompEntrance { get; set; }
        // public bool OverHeight { get; set; }
        // public int WimTypeId { get; set; }
        // public int ReaderTypeId { get; set; }
        // public int InternetProviderId { get; set; }
        // public bool IsMotionOnly { get; set; }
        // public bool IsWimDataFileTransferEnabled { get; set; }
        // public bool IsVisibleOnPublicPortal { get; set; }
        // public string Notes { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTimeOffset? LastModifiedDate { get; set; }
        public int HardwareStatus { get; set; }
        public DateTimeOffset? LastCreds { get; set; }
        public DateTimeOffset? LastWeights { get; set; }
        public DateTimeOffset? LastPullIn { get; set; }
        public DateTimeOffset? LastSoc { get; set; }
        public DateTimeOffset? LastPCL { get; set; }
        public DateTimeOffset? LastTrans { get; set; }
        public string SoftwareVersion { get; set; }
        public string MinSoftwareVersion { get; set; }
        // public string StateDescription { get; set; }
        // public string StationStatus { get; set; }
        // public int SiteTechId { get; set; }
        public string EmailIdList { get; set; }
        // public DateTimeOffset? LastSettingsChangeTime { get; set; }
        // public string SiteROCIP { get; set; }
        // public string GoogleMap { get; set; }
        // public DateTimeOffset? LastHealthMsg { get; set; }
        public int LastHealthKPI { get; set; }
        public int? LastVehicleProcMin { get; set; }
        public int? LastVehicleProcMax { get; set; }
        public int? OnlineStatusMin { get; set; }
        public int? OnlineStatusMax { get; set; }
        // public int PreclearanceMin { get; set; }
        // public int PreclearanceMid { get; set; }
        // public int PreclearanceMax { get; set; }
        public string UserModifiedBy { get; set; }
        public DateTimeOffset? UserModifiedDate { get; set; }
    }
}