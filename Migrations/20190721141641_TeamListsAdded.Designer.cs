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
    [Migration("20190721141641_TeamListsAdded")]
    partial class TeamListsAdded
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

                    b.Property<string>("PlayerPossition");

                    b.Property<string>("SSN");

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

            modelBuilder.Entity("PROPlanner.Models.DataModels.TeamList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PersonId");

                    b.Property<int?>("PersonId1");

                    b.Property<int?>("PersonId10");

                    b.Property<int?>("PersonId11");

                    b.Property<int?>("PersonId12");

                    b.Property<int?>("PersonId13");

                    b.Property<int?>("PersonId14");

                    b.Property<int?>("PersonId15");

                    b.Property<int?>("PersonId16");

                    b.Property<int?>("PersonId17");

                    b.Property<int?>("PersonId18");

                    b.Property<int?>("PersonId19");

                    b.Property<int?>("PersonId2");

                    b.Property<int?>("PersonId20");

                    b.Property<int?>("PersonId21");

                    b.Property<int?>("PersonId22");

                    b.Property<int?>("PersonId23");

                    b.Property<int?>("PersonId24");

                    b.Property<int?>("PersonId3");

                    b.Property<int?>("PersonId4");

                    b.Property<int?>("PersonId5");

                    b.Property<int?>("PersonId6");

                    b.Property<int?>("PersonId7");

                    b.Property<int?>("PersonId8");

                    b.Property<int?>("PersonId9");

                    b.Property<int?>("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("PersonId1");

                    b.HasIndex("PersonId10");

                    b.HasIndex("PersonId11");

                    b.HasIndex("PersonId12");

                    b.HasIndex("PersonId13");

                    b.HasIndex("PersonId14");

                    b.HasIndex("PersonId15");

                    b.HasIndex("PersonId16");

                    b.HasIndex("PersonId17");

                    b.HasIndex("PersonId18");

                    b.HasIndex("PersonId19");

                    b.HasIndex("PersonId2");

                    b.HasIndex("PersonId20");

                    b.HasIndex("PersonId21");

                    b.HasIndex("PersonId22");

                    b.HasIndex("PersonId23");

                    b.HasIndex("PersonId24");

                    b.HasIndex("PersonId3");

                    b.HasIndex("PersonId4");

                    b.HasIndex("PersonId5");

                    b.HasIndex("PersonId6");

                    b.HasIndex("PersonId7");

                    b.HasIndex("PersonId8");

                    b.HasIndex("PersonId9");

                    b.HasIndex("TeamId");

                    b.ToTable("TeamList");
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

            modelBuilder.Entity("PROPlanner.Models.RefModels.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ArenaId");

                    b.Property<int?>("AwayTeamScore");

                    b.Property<int?>("GameCategoryId");

                    b.Property<DateTime>("GameDateTime");

                    b.Property<string>("GameNumber");

                    b.Property<int?>("HomeTeamScore");

                    b.Property<bool>("Payed");

                    b.Property<bool>("Played");

                    b.Property<int?>("RefereeId");

                    b.Property<int?>("RefereeId1");

                    b.Property<int?>("RefereeId2");

                    b.Property<int?>("RefereeId3");

                    b.Property<string>("TSMNumber");

                    b.Property<int?>("TeamId");

                    b.Property<int?>("TeamId1");

                    b.Property<int?>("TournamentId");

                    b.HasKey("Id");

                    b.HasIndex("ArenaId");

                    b.HasIndex("GameCategoryId");

                    b.HasIndex("RefereeId");

                    b.HasIndex("RefereeId1");

                    b.HasIndex("RefereeId2");

                    b.HasIndex("RefereeId3");

                    b.HasIndex("TeamId");

                    b.HasIndex("TeamId1");

                    b.HasIndex("TournamentId");

                    b.ToTable("Match");
                });

            modelBuilder.Entity("PROPlanner.Models.RefModels.RefReceipt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MatchId");

                    b.Property<int>("REF1Allowance");

                    b.Property<string>("REF1Date");

                    b.Property<int>("REF1Fee");

                    b.Property<string>("REF1From");

                    b.Property<int>("REF1LateGame");

                    b.Property<bool>("REF1Paid");

                    b.Property<int>("REF1ParkingFee");

                    b.Property<string>("REF1Sign");

                    b.Property<string>("REF1To");

                    b.Property<int>("REF1Toll");

                    b.Property<int>("REF1TotalPayment");

                    b.Property<int>("REF1TravelKost");

                    b.Property<int>("REF1TravelKostperkm");

                    b.Property<int>("REF1TravellengthKm");

                    b.Property<int>("REF2Allowance");

                    b.Property<string>("REF2Date");

                    b.Property<int>("REF2Fee");

                    b.Property<string>("REF2From");

                    b.Property<int>("REF2LateGame");

                    b.Property<bool>("REF2Paid");

                    b.Property<int>("REF2ParkingFee");

                    b.Property<string>("REF2Sign");

                    b.Property<string>("REF2To");

                    b.Property<int>("REF2Toll");

                    b.Property<int>("REF2TotalPayment");

                    b.Property<int>("REF2TravelKost");

                    b.Property<int>("REF2TravelKostperkm");

                    b.Property<int>("REF2TravellengthKm");

                    b.Property<int>("REF3Allowance");

                    b.Property<string>("REF3Date");

                    b.Property<int>("REF3Fee");

                    b.Property<string>("REF3From");

                    b.Property<int>("REF3LateGame");

                    b.Property<bool>("REF3Paid");

                    b.Property<int>("REF3ParkingFee");

                    b.Property<string>("REF3Sign");

                    b.Property<string>("REF3To");

                    b.Property<int>("REF3Toll");

                    b.Property<int>("REF3TotalPayment");

                    b.Property<int>("REF3TravelKost");

                    b.Property<int>("REF3TravelKostperkm");

                    b.Property<int>("REF3TravellengthKm");

                    b.Property<int>("REF4Allowance");

                    b.Property<string>("REF4Date");

                    b.Property<int>("REF4Fee");

                    b.Property<string>("REF4From");

                    b.Property<int>("REF4LateGame");

                    b.Property<bool>("REF4Paid");

                    b.Property<int>("REF4ParkingFee");

                    b.Property<string>("REF4Sign");

                    b.Property<string>("REF4To");

                    b.Property<int>("REF4Toll");

                    b.Property<int>("REF4TotalPayment");

                    b.Property<int>("REF4TravelKost");

                    b.Property<int>("REF4TravelKostperkm");

                    b.Property<int>("REF4TravellengthKm");

                    b.Property<int?>("RefereeId");

                    b.Property<int?>("RefereeId1");

                    b.Property<int?>("RefereeId2");

                    b.Property<int?>("RefereeId3");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.HasIndex("RefereeId");

                    b.HasIndex("RefereeId1");

                    b.HasIndex("RefereeId2");

                    b.HasIndex("RefereeId3");

                    b.ToTable("RefReceipt");
                });

            modelBuilder.Entity("PROPlanner.Models.RefModels.Referee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BankAccount");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber1");

                    b.Property<string>("PhoneNumber2");

                    b.Property<int?>("RefereeTypeId");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("SwishAccount");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.HasIndex("RefereeTypeId");

                    b.ToTable("Referee");
                });

            modelBuilder.Entity("PROPlanner.Models.RefModels.RefereeType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RefereeTypeName");

                    b.HasKey("Id");

                    b.ToTable("RefreeType");
                });

            modelBuilder.Entity("PROPlanner.Models.Tournament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TournamentName");

                    b.HasKey("Id");

                    b.ToTable("Tournament");
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

            modelBuilder.Entity("PROPlanner.Models.DataModels.TeamList", b =>
                {
                    b.HasOne("PROPlanner.Models.DataModels.Person", "HeadCoach")
                        .WithMany()
                        .HasForeignKey("PersonId");

                    b.HasOne("PROPlanner.Models.DataModels.Person", "AssCoach")
                        .WithMany()
                        .HasForeignKey("PersonId1");

                    b.HasOne("PROPlanner.Models.DataModels.Person", "Defense6")
                        .WithMany()
                        .HasForeignKey("PersonId10");

                    b.HasOne("PROPlanner.Models.DataModels.Person", "Defense7")
                        .WithMany()
                        .HasForeignKey("PersonId11");

                    b.HasOne("PROPlanner.Models.DataModels.Person", "Defense8")
                        .WithMany()
                        .HasForeignKey("PersonId12");

                    b.HasOne("PROPlanner.Models.DataModels.Person", "Offense1")
                        .WithMany()
                        .HasForeignKey("PersonId13");

                    b.HasOne("PROPlanner.Models.DataModels.Person", "Offense2")
                        .WithMany()
                        .HasForeignKey("PersonId14");

                    b.HasOne("PROPlanner.Models.DataModels.Person", "Offense3")
                        .WithMany()
                        .HasForeignKey("PersonId15");

                    b.HasOne("PROPlanner.Models.DataModels.Person", "Offense4")
                        .WithMany()
                        .HasForeignKey("PersonId16");

                    b.HasOne("PROPlanner.Models.DataModels.Person", "Offense5")
                        .WithMany()
                        .HasForeignKey("PersonId17");

                    b.HasOne("PROPlanner.Models.DataModels.Person", "Offense6")
                        .WithMany()
                        .HasForeignKey("PersonId18");

                    b.HasOne("PROPlanner.Models.DataModels.Person", "Offense7")
                        .WithMany()
                        .HasForeignKey("PersonId19");

                    b.HasOne("PROPlanner.Models.DataModels.Person", "TeamLeader")
                        .WithMany()
                        .HasForeignKey("PersonId2");

                    b.HasOne("PROPlanner.Models.DataModels.Person", "Offense8")
                        .WithMany()
                        .HasForeignKey("PersonId20");

                    b.HasOne("PROPlanner.Models.DataModels.Person", "Offense9")
                        .WithMany()
                        .HasForeignKey("PersonId21");

                    b.HasOne("PROPlanner.Models.DataModels.Person", "Offense10")
                        .WithMany()
                        .HasForeignKey("PersonId22");

                    b.HasOne("PROPlanner.Models.DataModels.Person", "Offense11")
                        .WithMany()
                        .HasForeignKey("PersonId23");

                    b.HasOne("PROPlanner.Models.DataModels.Person", "Offense12")
                        .WithMany()
                        .HasForeignKey("PersonId24");

                    b.HasOne("PROPlanner.Models.DataModels.Person", "Goalie1")
                        .WithMany()
                        .HasForeignKey("PersonId3");

                    b.HasOne("PROPlanner.Models.DataModels.Person", "Goalie2")
                        .WithMany()
                        .HasForeignKey("PersonId4");

                    b.HasOne("PROPlanner.Models.DataModels.Person", "Defense1")
                        .WithMany()
                        .HasForeignKey("PersonId5");

                    b.HasOne("PROPlanner.Models.DataModels.Person", "Defense2")
                        .WithMany()
                        .HasForeignKey("PersonId6");

                    b.HasOne("PROPlanner.Models.DataModels.Person", "Defense3")
                        .WithMany()
                        .HasForeignKey("PersonId7");

                    b.HasOne("PROPlanner.Models.DataModels.Person", "Defense4")
                        .WithMany()
                        .HasForeignKey("PersonId8");

                    b.HasOne("PROPlanner.Models.DataModels.Person", "Defense5")
                        .WithMany()
                        .HasForeignKey("PersonId9");

                    b.HasOne("PROPlanner.Models.DataModels.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("PROPlanner.Models.RefModels.Match", b =>
                {
                    b.HasOne("PROPlanner.Models.DataModels.Arena", "Arena")
                        .WithMany()
                        .HasForeignKey("ArenaId");

                    b.HasOne("PROPlanner.Models.DataModels.GameCategory", "GameCategory")
                        .WithMany()
                        .HasForeignKey("GameCategoryId");

                    b.HasOne("PROPlanner.Models.RefModels.Referee", "HD1")
                        .WithMany()
                        .HasForeignKey("RefereeId");

                    b.HasOne("PROPlanner.Models.RefModels.Referee", "HD2")
                        .WithMany()
                        .HasForeignKey("RefereeId1");

                    b.HasOne("PROPlanner.Models.RefModels.Referee", "LD1")
                        .WithMany()
                        .HasForeignKey("RefereeId2");

                    b.HasOne("PROPlanner.Models.RefModels.Referee", "LD2")
                        .WithMany()
                        .HasForeignKey("RefereeId3");

                    b.HasOne("PROPlanner.Models.DataModels.Team", "HomeTeam")
                        .WithMany()
                        .HasForeignKey("TeamId");

                    b.HasOne("PROPlanner.Models.DataModels.Team", "AwayTeam")
                        .WithMany()
                        .HasForeignKey("TeamId1");

                    b.HasOne("PROPlanner.Models.Tournament", "Tournament")
                        .WithMany("Matches")
                        .HasForeignKey("TournamentId");
                });

            modelBuilder.Entity("PROPlanner.Models.RefModels.RefReceipt", b =>
                {
                    b.HasOne("PROPlanner.Models.RefModels.Match", "Match")
                        .WithMany()
                        .HasForeignKey("MatchId");

                    b.HasOne("PROPlanner.Models.RefModels.Referee", "REF1")
                        .WithMany()
                        .HasForeignKey("RefereeId");

                    b.HasOne("PROPlanner.Models.RefModels.Referee", "REF2")
                        .WithMany()
                        .HasForeignKey("RefereeId1");

                    b.HasOne("PROPlanner.Models.RefModels.Referee", "REF3")
                        .WithMany()
                        .HasForeignKey("RefereeId2");

                    b.HasOne("PROPlanner.Models.RefModels.Referee", "REF4")
                        .WithMany()
                        .HasForeignKey("RefereeId3");
                });

            modelBuilder.Entity("PROPlanner.Models.RefModels.Referee", b =>
                {
                    b.HasOne("PROPlanner.Models.RefModels.RefereeType", "RefereeType")
                        .WithMany()
                        .HasForeignKey("RefereeTypeId");
                });
#pragma warning restore 612, 618
        }
    }
}
