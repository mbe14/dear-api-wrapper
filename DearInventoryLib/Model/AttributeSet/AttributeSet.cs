﻿using System.Collections.Generic;

namespace DearInventoryLib.Model.AttributeSet
{
    public class AttributeSet : PagedData
    {
        public List<AttributeSetList> AttributeSetList { get; set; }
        public AttributeSetList LocationList { get; set; }
    }
}
