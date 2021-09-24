using System;

namespace DearInventoryLib.Model.Location
{
    public class Location : DIModel
    {
        public string Name { get; set; }
        public bool IsDefault { get; set; }
        public bool Deprecated { get; set; }
        public BinArray[] Bins { get; set; }
        public bool FixedAssetsLocation { get; set; }
        public Guid ParentID {  get; set; }
        public int ReferenceCount {  get; set; }
        public string AddressLine1 {  get; set; }
        public string AddressLine2 {  get; set;}
        public string AddressCitySuburb {  get; set;}
        public string AddressStateProvince {  get; set;}            
        public string AddressZipPostCode {  get; set;}
        public string AddressCountry {  get; set;}
        public string PickZones {  get; set;}
        public bool IsCoMan { get; set; }
        public bool IsStaging { get; set; }
    }

    public class BinArray : DIModel
    {
        public string Name { get; set; }
    }
}
