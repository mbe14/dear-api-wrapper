using System;

namespace DearInventoryLib.Model.Common
{
    public class Contact
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Comment { get; set; }
        public bool Default { get; set; }
        public bool IncludeInEmail { get; set; }
    }
}
