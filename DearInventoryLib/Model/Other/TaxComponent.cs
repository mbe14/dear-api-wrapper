using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearInventoryLib.Model.Other
{
    public class TaxComponent
    {
        public string Name { get; set; }
        public decimal Percent { get; set; }
        public string AccountCode { get; set; }
        public int ComponentOrder { get; set; }
        
    }
}
