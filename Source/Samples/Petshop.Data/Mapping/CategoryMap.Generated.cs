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

namespace Petshop.Data.Mapping
{
    public partial class CategoryMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Petshop.Data.Entities.Category>
    {
        public CategoryMap()
        {
            // table
            ToTable("Category", "dbo");

            // keys
            HasKey(t => t.CatId);

            // Properties
            Property(t => t.CatId)
                .HasColumnName("CatId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasMaxLength(10)
                .IsRequired();
            Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(80)
                .IsOptional();
            Property(t => t.Descn)
                .HasColumnName("Descn")
                .HasMaxLength(255)
                .IsOptional();

            // Relationships

            InitializeMapping();
        }
    }
}
