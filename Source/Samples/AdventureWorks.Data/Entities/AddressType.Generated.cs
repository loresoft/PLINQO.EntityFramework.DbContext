﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorks.Data.Entities
{
    public partial class AddressType
    {
        public AddressType()
        {
            ModifiedDate = DateTime.Now;
            VendorAddresses = new List<VendorAddress>();
            CustomerAddresses = new List<CustomerAddress>();
        }

        public int AddressTypeID { get; set; }
        public string Name { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<VendorAddress> VendorAddresses { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }
    }
}