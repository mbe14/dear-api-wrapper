using System;
using System.Collections.Generic;

namespace DearInventoryLib.Model
{
    public class AttributeSet
    {
        public int Total { get; set; }
        public int Page { get; set; }
        public List<AttributeSetList> AttributeSetList { get; set; }
        public AttributeSetList LocationList { get; set; }
    }

    public class Attribute
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Values { get; set; }
    }

    public class AttributeSetList
    {
        public Guid ID { get; set; } //Required for PUT and DELETE, Ignored for POST operations
        public string Name { get; set; }
        public string Attribute1Name { get; set; }
        public string Attribute1Type { get; set; }
        public string Attribute1Values { get; set; }
        public string Attribute2Name { get; set; }
        public string Attribute2Type { get; set; }
        public string Attribute2Values { get; set; }
        public string Attribute3Name { get; set; }
        public string Attribute3Type { get; set; }
        public string Attribute3Values { get; set; }
        public string Attribute4Name { get; set; }
        public string Attribute4Type { get; set; }
        public string Attribute4Values { get; set; }
        public string Attribute5Name { get; set; }
        public string Attribute5Type { get; set; }
        public string Attribute5Values { get; set; }
        public string Attribute6Name { get; set; }
        public string Attribute6Type { get; set; }
        public string Attribute6Values { get; set; }
        public string Attribute7Name { get; set; }
        public string Attribute7Type { get; set; }
        public string Attribute7Values { get; set; }
        public string Attribute8Name { get; set; }
        public string Attribute8Type { get; set; }
        public string Attribute8Values { get; set; }
        public string Attribute9Name { get; set; }
        public string Attribute9Type { get; set; }
        public string Attribute9Values { get; set; }
        public string Attribute10Name { get; set; }
        public string Attribute10Type { get; set; }
        public string Attribute10Values { get; set; }
        public Attribute[] Attributes { get; set; }
    }
}
