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
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdventureWorks.Data.Mapping
{
    public partial class ProductPhotoMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AdventureWorks.Data.Entities.ProductPhoto>
    {
        public ProductPhotoMap()
        {
            // table
            ToTable("ProductPhoto", "Production");

            // keys
            HasKey(t => t.ProductPhotoID);

            // Properties
            Property(t => t.ProductPhotoID)
                .HasColumnName("ProductPhotoID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.ThumbNailPhoto)
                .HasColumnName("ThumbNailPhoto")
                .IsOptional();
            Property(t => t.ThumbnailPhotoFileName)
                .HasColumnName("ThumbnailPhotoFileName")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.LargePhoto)
                .HasColumnName("LargePhoto")
                .IsOptional();
            Property(t => t.LargePhotoFileName)
                .HasColumnName("LargePhotoFileName")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships

            InitializeMapping();
        }
    }
}
