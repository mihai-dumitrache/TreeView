﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TreeView.Models;

namespace TreeView.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20220323221748_updated-model")]
    partial class updatedmodel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TreeView.Models.Step", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ParentStepId")
                        .HasColumnType("int");

                    b.Property<string>("StepDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StepResponsible")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TaskId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParentStepId");

                    b.HasIndex("TaskId");

                    b.ToTable("Steps");
                });

            modelBuilder.Entity("TreeView.Models.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TaskTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("TreeView.Models.Step", b =>
                {
                    b.HasOne("TreeView.Models.Step", "ParentStep")
                        .WithMany("SubSteps")
                        .HasForeignKey("ParentStepId");

                    b.HasOne("TreeView.Models.Task", "Task")
                        .WithMany("StepsList")
                        .HasForeignKey("TaskId");

                    b.Navigation("ParentStep");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("TreeView.Models.Step", b =>
                {
                    b.Navigation("SubSteps");
                });

            modelBuilder.Entity("TreeView.Models.Task", b =>
                {
                    b.Navigation("StepsList");
                });
#pragma warning restore 612, 618
        }
    }
}
