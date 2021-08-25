using DearInventoryLib.Model;
using System;
using System.Collections.Generic;

namespace DearInventoryLib.Interface
{
    interface IAttributeSetRequest
    {
        List<AttributeSetList> GetAll();
        AttributeSetList GetById(Guid Guid);
        AttributeSetList GetByName(string Name);
        string Add(AttributeSetList Attribute);
        bool Edit(AttributeSetList Attribute); //ID is mandatory
        bool Delete(Guid Guid);
    }
}
