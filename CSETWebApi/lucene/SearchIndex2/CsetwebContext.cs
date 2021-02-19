﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Collections.Generic;
using System.Linq;

namespace SearchIndex2
{
    public partial class CsetwebContext : DbContext
    {
        public CsetwebContext()
        {
        }

        public CsetwebContext(DbContextOptions<CsetwebContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["CSETWebEntities"].ConnectionString;
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        public virtual DbSet<CATALOG_RECOMMENDATIONS_DATA> CATALOG_RECOMMENDATIONS_DATA { get; set; }
        public virtual DbSet<CATALOG_RECOMMENDATIONS_HEADINGS> CATALOG_RECOMMENDATIONS_HEADINGS { get; set; }
        public virtual DbSet<FILE_KEYWORDS> FILE_KEYWORDS { get; set; }
        public virtual DbSet<FILE_REF_KEYS> FILE_REF_KEYS { get; set; }
        public virtual DbSet<GEN_FILE> GEN_FILE { get; set; }
        public virtual DbSet<PROCUREMENT_LANGUAGE_DATA> PROCUREMENT_LANGUAGE_DATA { get; set; }
        public virtual DbSet<PROCUREMENT_LANGUAGE_HEADINGS> PROCUREMENT_LANGUAGE_HEADINGS { get; set; }
        public virtual DbSet<REF_LIBRARY_PATH> REF_LIBRARY_PATH { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CATALOG_RECOMMENDATIONS_DATA>(entity =>
            {
                entity.HasKey(e => e.Data_Id)
                    .HasName("PK_Catalog_Recommendations_Data");

                entity.HasComment("A collection of CATALOG_RECOMMENDATIONS_DATA records");

                entity.Property(e => e.Data_Id).HasComment("The Data Id is used to");

                entity.Property(e => e.Enhancement).HasComment("The Enhancement is used to");

                entity.Property(e => e.Enhancement_Html).HasComment("The Enhancement Html is used to");

                entity.Property(e => e.Flow_Document).HasComment("The Flow Document is used to");

                entity.Property(e => e.Heading).HasComment("The Heading is used to");

                entity.Property(e => e.Heading_Html).HasComment("The Heading Html is used to");

                entity.Property(e => e.Parent_Heading_Id).HasComment("The Parent Heading Id is used to");

                entity.Property(e => e.Req_Oracle_Id).HasComment("The Req Oracle Id is used to");

                entity.Property(e => e.Requirement).HasComment("The Requirement is used to");

                entity.Property(e => e.Requirement_Html).HasComment("The Requirement Html is used to");

                entity.Property(e => e.Requirement_Text).HasComment("The Requirement Text is used to");

                entity.Property(e => e.Section_Long_Number)
                    .HasMaxLength(50)
                    .HasComment("The Section Long Number is used to");

                entity.Property(e => e.Section_Short_Name)
                    .HasMaxLength(150)
                    .HasComment("The Section Short Name is used to");

                entity.Property(e => e.Section_Short_Number)
                    .HasMaxLength(50)
                    .HasComment("The Section Short Number is used to");

                entity.Property(e => e.Supplemental_Guidance).HasComment("The Supplemental Guidance is used to");

                entity.Property(e => e.Supplemental_Guidance_Html).HasComment("The Supplemental Guidance Html is used to");

                entity.Property(e => e.Topic_Name)
                    .HasMaxLength(150)
                    .HasComment("The Topic Name is used to");

                entity.HasOne(d => d.Parent_Heading_)
                    .WithMany(p => p.CATALOG_RECOMMENDATIONS_DATAs)
                    .HasForeignKey(d => d.Parent_Heading_Id)
                    .HasConstraintName("FK_CATALOG_RECOMMENDATIONS_DATA_CATALOG_RECOMMENDATIONS_HEADINGS");
            });

            modelBuilder.Entity<CATALOG_RECOMMENDATIONS_HEADINGS>(entity =>
            {
                entity.HasComment("A collection of CATALOG_RECOMMENDATIONS_HEADINGS records");

                entity.Property(e => e.Id).HasComment("The Id is used to");

                entity.Property(e => e.Heading_Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("The Heading Name is used to");

                entity.Property(e => e.Heading_Num).HasComment("The Heading Num is used to");
            });

            modelBuilder.Entity<FILE_KEYWORDS>(entity =>
            {
                entity.HasKey(e => new { e.Gen_File_Id, e.Keyword })
                    .HasName("FILE_KEYWORDS_PK");

                entity.HasComment("A collection of FILE_KEYWORDS records");

                entity.Property(e => e.Gen_File_Id).HasComment("The Gen File Id is used to");

                entity.Property(e => e.Keyword)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasComment("The Keyword is used to");

                entity.HasOne(d => d.Gen_File_)
                    .WithMany(p => p.FILE_KEYWORDs)
                    .HasForeignKey(d => d.Gen_File_Id)
                    .HasConstraintName("FILE_KEYWORDS_GEN_FILE_FK");
            });

            modelBuilder.Entity<FILE_REF_KEYS>(entity =>
            {
                entity.HasKey(e => e.Doc_Num);

                entity.HasComment("A collection of FILE_REF_KEYS records");

                entity.Property(e => e.Doc_Num)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasComment("The Doc Num is used to");
            });

            modelBuilder.Entity<GEN_FILE>(entity =>
            {
                entity.HasKey(e => e.Gen_File_Id)
                    .HasName("SYS_C0014438");

                entity.HasComment("A collection of GEN_FILE records");

                entity.Property(e => e.Gen_File_Id).HasComment("The Gen File Id is used to");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("The Comments is used to");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("The Description is used to");

                entity.Property(e => e.Doc_Num)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('NONE')")
                    .HasComment("The Doc Num is used to");

                entity.Property(e => e.Doc_Version)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("The Doc Version is used to");

                entity.Property(e => e.File_Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("The File Name is used to");

                entity.Property(e => e.File_Size).HasComment("The File Size is used to");

                entity.Property(e => e.File_Type_Id)
                    .HasColumnType("numeric(38, 0)")
                    .HasComment("The File Type Id is used to");

                entity.Property(e => e.Is_Uploaded)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("The Name is used to");

                entity.Property(e => e.Publish_Date)
                    .HasColumnType("datetime")
                    .HasComment("The Publish Date is used to");

                entity.Property(e => e.Short_Name)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasComment("The Short Name is used to");

                entity.Property(e => e.Source_Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("The Source Type is used to");

                entity.Property(e => e.Summary)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasComment("The Summary is used to");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("The Title is used to");

                entity.HasOne(d => d.Doc_NumNavigation)
                    .WithMany(p => p.GEN_FILEs)
                    .HasForeignKey(d => d.Doc_Num)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GEN_FILE_FILE_REF_KEYS");
            });

            modelBuilder.Entity<PROCUREMENT_LANGUAGE_DATA>(entity =>
            {
                entity.HasKey(e => e.Procurement_Id)
                    .HasName("PK_Procurement_Language_Data");

                entity.HasComment("A collection of PROCUREMENT_LANGUAGE_DATA records");

                entity.Property(e => e.Procurement_Id).HasComment("The Procurement Id is used to");

                entity.Property(e => e.Basis).HasComment("The Basis is used to");

                entity.Property(e => e.Fatmeasures).HasComment("The Fatmeasures is used to");

                entity.Property(e => e.Flow_Document).HasComment("The Flow Document is used to");

                entity.Property(e => e.Heading).HasComment("The Heading is used to");

                entity.Property(e => e.Language_Guidance).HasComment("The Language Guidance is used to");

                entity.Property(e => e.Maintenance_Guidance).HasComment("The Maintenance Guidance is used to");

                entity.Property(e => e.Parent_Heading_Id).HasComment("The Parent Heading Id is used to");

                entity.Property(e => e.Procurement_Language).HasComment("The Procurement Language is used to");

                entity.Property(e => e.References_Doc).HasComment("The References Doc is used to");

                entity.Property(e => e.Satmeasures).HasComment("The Satmeasures is used to");

                entity.Property(e => e.Section_Number)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("The Section Number is used to");

                entity.Property(e => e.Topic_Name).HasComment("The Topic Name is used to");

                entity.HasOne(d => d.Parent_Heading_)
                    .WithMany(p => p.PROCUREMENT_LANGUAGE_DATAs)
                    .HasForeignKey(d => d.Parent_Heading_Id)
                    .HasConstraintName("FK_PROCUREMENT_LANGUAGE_DATA_PROCUREMENT_LANGUAGE_HEADINGS");
            });

            modelBuilder.Entity<PROCUREMENT_LANGUAGE_HEADINGS>(entity =>
            {
                entity.HasComment("A collection of PROCUREMENT_LANGUAGE_HEADINGS records");

                entity.Property(e => e.Id).HasComment("The Id is used to");

                entity.Property(e => e.Heading_Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("The Heading Name is used to");

                entity.Property(e => e.Heading_Num).HasComment("The Heading Num is used to");
            });

            modelBuilder.Entity<REF_LIBRARY_PATH>(entity =>
            {
                entity.HasKey(e => e.Lib_Path_Id)
                    .HasName("REF_LIBRARY_PATH_PK");

                entity.HasComment("A collection of REF_LIBRARY_PATH records");

                entity.Property(e => e.Lib_Path_Id)
                    .HasColumnType("numeric(38, 0)")
                    .HasComment("The Lib Path Id is used to");

                entity.Property(e => e.Parent_Path_Id)
                    .HasColumnType("numeric(38, 0)")
                    .HasComment("The Parent Path Id is used to");

                entity.Property(e => e.Path_Name)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasComment("The Path Name is used to");

                entity.HasOne(d => d.Parent_Path_)
                    .WithMany(p => p.InverseParent_Path_)
                    .HasForeignKey(d => d.Parent_Path_Id)
                    .HasConstraintName("FK_REF_LIBRARY_PATH_REF_LIBRARY_PATH");
            });

            modelBuilder.HasSequence<int>("MaturityNodeSequence");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}