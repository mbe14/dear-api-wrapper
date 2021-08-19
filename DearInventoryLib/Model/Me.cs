using System;

namespace DearInventoryLib.Model
{
    public class Me
    {
        public string Company { get; set; }
        public string Currency { get; set; }
        public string TimeZone { get; set; }
        public string DefaultWeightUnits { get; set; }
        public string DefaultDimensionsUnits { get; set; }
        public DateTime? LockDate { get; set; }
        public DateTime OpeningBalanceDate { get; set; }
    }
}
