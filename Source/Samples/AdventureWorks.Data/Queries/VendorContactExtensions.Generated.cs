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
using System.Linq;
using System.Text;

namespace AdventureWorks.Data.Queries
{
    public static partial class VendorContactExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static AdventureWorks.Data.Entities.VendorContact GetByKey(this System.Linq.IQueryable<AdventureWorks.Data.Entities.VendorContact> queryable, int vendorID, int contactID)
        {
            var dbSet = queryable as System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.VendorContact>;
            if (dbSet != null)
                return dbSet.Find(vendorID, contactID);
                
            return queryable.FirstOrDefault(v => v.VendorID == vendorID
                && v.ContactID == contactID);
        }

        public static IQueryable<AdventureWorks.Data.Entities.VendorContact> ByContactID(this IQueryable<AdventureWorks.Data.Entities.VendorContact> queryable, int contactID)
        {
            return queryable.Where(v => v.ContactID == contactID);
        }

        public static IQueryable<AdventureWorks.Data.Entities.VendorContact> ByContactTypeID(this IQueryable<AdventureWorks.Data.Entities.VendorContact> queryable, int contactTypeID)
        {
            return queryable.Where(v => v.ContactTypeID == contactTypeID);
        }

        public static IQueryable<AdventureWorks.Data.Entities.VendorContact> ByVendorID(this IQueryable<AdventureWorks.Data.Entities.VendorContact> queryable, int vendorID)
        {
            return queryable.Where(v => v.VendorID == vendorID);
        }
    }
}
