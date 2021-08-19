using DearInventoryLib.Model;
using System;
using System.Collections.Generic;

namespace DearInventoryLib.Interface
{
    interface IAttributeSetRequest
    {
        List<AttributeSetList> GetAll();
        AttributeSetList GetById(Guid guid);
        AttributeSetList GetByName(string name);
        string Add(AttributeSetList attribute);
        bool Edit(AttributeSetList attribute); //ID is mandatory
        bool Delete(Guid guid);
    }
}
