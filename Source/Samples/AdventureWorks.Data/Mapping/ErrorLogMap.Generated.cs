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
    public partial class ErrorLogMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AdventureWorks.Data.Entities.ErrorLog>
    {
        public ErrorLogMap()
        {
            // table
            ToTable("ErrorLog", "dbo");

            // keys
            HasKey(t => t.ErrorLogID);

            // Properties
            Property(t => t.ErrorLogID)
                .HasColumnName("ErrorLogID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.ErrorTime)
                .HasColumnName("ErrorTime")
                .IsRequired();
            Property(t => t.UserName)
                .HasColumnName("UserName")
                .HasMaxLength(128)
                .IsRequired();
            Property(t => t.ErrorNumber)
                .HasColumnName("ErrorNumber")
                .IsRequired();
            Property(t => t.ErrorSeverity)
                .HasColumnName("ErrorSeverity")
                .IsOptional();
            Property(t => t.ErrorState)
                .HasColumnName("ErrorState")
                .IsOptional();
            Property(t => t.ErrorProcedure)
                .HasColumnName("ErrorProcedure")
                .HasMaxLength(126)
                .IsOptional();
            Property(t => t.ErrorLine)
                .HasColumnName("ErrorLine")
                .IsOptional();
            Property(t => t.ErrorMessage)
                .HasColumnName("ErrorMessage")
                .HasMaxLength(4000)
                .IsRequired();

            // Relationships

            InitializeMapping();
        }
    }
}
