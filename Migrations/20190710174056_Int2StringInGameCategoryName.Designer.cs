﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PROPlanner.Models;

namespace PROPlanner.Migrations
{
    [DbContext(typeof(PROPlannerContext))]
    [Migration("20190710174056_Int2StringInGameCategoryName")]
    partial class Int2StringInGameCategoryName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PROPlanner.Models.DataModels.Arena", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArenaName");

                    b.HasKey("Id");

                    b.ToTable("Arena");
                });

            modelBuilder.Entity("PROPlanner.Models.DataModels.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName");

                    b.HasKey("Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("PROPlanner.Models.DataModels.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ArenaId");

                    b.Property<int?>("AwayTeamScore");

                    b.Property<int?>("GameCategoryId");

                    b.Property<DateTime>("GameDateTime");

                    b.Property<string>("GameNumber");

                    b.Property<int>("GameTotalKost");

                    b.Property<int>("HD1Alowens");

                    b.Property<int>("HD1Fee");

                    b.Property<int>("HD1LateGameKost");

                    b.Property<int>("HD1TotalFee");

                    b.Property<int>("HD1TravelKost");

                    b.Property<int>("HD2Alowens");

                    b.Property<int>("HD2Fee");

                    b.Property<int>("HD2LateGameKost");

                    b.Property<int>("HD2TotalFee");

                    b.Property<int>("HD2TravelKost");

                    b.Property<int?>("HomeTeamScore");

                    b.Property<int>("LD1Alowens");

                    b.Property<int>("LD1Fee");

                    b.Property<int>("LD1LateGameKost");

                    b.Property<int>("LD1TotalFee");

                    b.Property<int>("LD1TravelKost");

                    b.Property<int>("LD2Alowens");

                    b.Property<int>("LD2Fee");

                    b.Property<int>("LD2LateGameKost");

                    b.Property<int>("LD2TotalFee");

                    b.Property<int>("LD2TravelKost");

                    b.Property<int?>("PersonId");

                    b.Property<int?>("PersonId1");

                    b.Property<int?>("PersonId2");

                    b.Property<int?>("PersonId3");

                    b.Property<int?>("TeamId");

                    b.Property<int?>("TeamId1");

                    b.HasKey("Id");

                    b.HasIndex("ArenaId");

                    b.HasIndex("GameCategoryId");

                    b.HasIndex("PersonId");

                    b.HasIndex("PersonId1");

                    b.HasIndex("PersonId2");

                    b.HasIndex("PersonId3");

                    b.HasIndex("TeamId");

                    b.HasIndex("TeamId1");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("PROPlanner.Models.DataModels.GameCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GameCategoryName");

                    b.HasKey("Id");

                    b.ToTable("GameCategory");
                });

            modelBuilder.Entity("PROPlanner.Models.DataModels.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<int?>("CompanyId");

                    b.Property<string>("Country");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int?>("PersonTypeId");

                    b.Property<string>("PhoneNumber1");

                    b.Property<string>("PhoneNumber2");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("PersonTypeId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("PROPlanner.Models.DataModels.PersonType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PersonTypeName");

                    b.HasKey("Id");

                    b.ToTable("PersonType");
                });

            modelBuilder.Entity("PROPlanner.Models.DataModels.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PersonId");

                    b.Property<string>("ScheduleDescription");

                    b.Property<DateTime>("ScheduleEndDate");

                    b.Property<string>("ScheduleName");

                    b.Property<DateTime>("ScheduleStartDate");

                    b.Property<string>("ScheduleWeek");

                    b.Property<decimal>("TotalWorkedHours");

                    b.Property<int?>("WorkingDayId");

                    b.Property<int?>("WorkingDayId1");

                    b.Property<int?>("WorkingDayId2");

                    b.Property<int?>("WorkingDayId3");

                    b.Property<int?>("WorkingDayId4");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("WorkingDayId");

                    b.HasIndex("WorkingDayId1");

                    b.HasIndex("WorkingDayId2");

                    b.HasIndex("WorkingDayId3");

                    b.HasIndex("WorkingDayId4");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("PROPlanner.Models.DataModels.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TeamName");

                    b.HasKey("Id");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("PROPlanner.Models.DataModels.WorkingDay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("HoursWorked");

                    b.Property<string>("WorkingDayEnd");

                    b.Property<string>("WorkingDayName");

                    b.Property<string>("WorkingDayStart");

                    b.HasKey("Id");

                    b.ToTable("WorkingDay");
                });

            modelBuilder.Entity("PROPlanner.Models.DataModels.Game", b =>
                {
                    b.HasOne("PROPlanner.Models.DataModels.Arena", "Arena")
                        .WithMany()
                        .HasForeignKey("ArenaId");

                    b.HasOne("PROPlanner.Models.DataModels.GameCategory", "GameCategory")
                        .WithMany()
                        .HasForeignKey("GameCategoryId");

                    b.HasOne("PROPlanner.Models.DataModels.Person", "HD1")
                        .WithMany()
                        .HasForeignKey("PersonId");

                    b.HasOne("PROPlanner.Models.DataModels.Person", "HD2")
                        .WithMany()
                        .HasForeignKey("PersonId1");

                    b.HasOne("PROPlanner.Models.DataModels.Person", "LD1")
                        .WithMany()
                        .HasForeignKey("PersonId2");

                    b.HasOne("PROPlanner.Models.DataModels.Person", "LD2")
                        .WithMany()
                        .HasForeignKey("PersonId3");

                    b.HasOne("PROPlanner.Models.DataModels.Team", "HomeTeam")
                        .WithMany()
                        .HasForeignKey("TeamId");

                    b.HasOne("PROPlanner.Models.DataModels.Team", "AwayTeam")
                        .WithMany()
                        .HasForeignKey("TeamId1");
                });

            modelBuilder.Entity("PROPlanner.Models.DataModels.Person", b =>
                {
                    b.HasOne("PROPlanner.Models.DataModels.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("PROPlanner.Models.DataModels.PersonType", "PersonType")
                        .WithMany()
                        .HasForeignKey("PersonTypeId");
                });

            modelBuilder.Entity("PROPlanner.Models.DataModels.Schedule", b =>
                {
                    b.HasOne("PROPlanner.Models.DataModels.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");

                    b.HasOne("PROPlanner.Models.DataModels.WorkingDay", "WorkingDay")
                        .WithMany()
                        .HasForeignKey("WorkingDayId");

                    b.HasOne("PROPlanner.Models.DataModels.WorkingDay", "WorkingDay1")
                        .WithMany()
                        .HasForeignKey("WorkingDayId1");

                    b.HasOne("PROPlanner.Models.DataModels.WorkingDay", "WorkingDay3")
                        .WithMany()
                        .HasForeignKey("WorkingDayId2");

                    b.HasOne("PROPlanner.Models.DataModels.WorkingDay", "WorkingDay4")
                        .WithMany()
                        .HasForeignKey("WorkingDayId3");

                    b.HasOne("PROPlanner.Models.DataModels.WorkingDay", "WorkingDay5")
                        .WithMany()
                        .HasForeignKey("WorkingDayId4");
                });
#pragma warning restore 612, 618
        }
    }
}
