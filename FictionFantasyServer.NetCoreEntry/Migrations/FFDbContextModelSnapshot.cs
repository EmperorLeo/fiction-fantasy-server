﻿// <auto-generated />
using System;
using System.Collections.Generic;
using FictionFantasyServer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FictionFantasyServer.NetCoreEntry.Migrations
{
    [DbContext(typeof(FFDbContext))]
    partial class FFDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("FictionFantasyServer.Data.Entities.BookCharacterEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("BookId");

                    b.Property<Guid>("CharacterId");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime?>("Modified");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("CharacterId");

                    b.ToTable("BookCharacterEntity");
                });

            modelBuilder.Entity("FictionFantasyServer.Data.Entities.BookEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AuthorId");

                    b.Property<DateTime>("Created");

                    b.Property<string>("MainIdea");

                    b.Property<DateTime?>("Modified");

                    b.Property<int>("PrimaryGenre");

                    b.Property<string>("Title");

                    b.Property<int>("Viewpoint");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("FictionFantasyServer.Data.Entities.BookIntroductionEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("BookId");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime?>("Modified");

                    b.Property<List<string>>("PersonalityTraits");

                    b.Property<List<string>>("Relationships");

                    b.Property<List<string>>("Settings");

                    b.Property<string>("Summary");

                    b.HasKey("Id");

                    b.HasIndex("BookId")
                        .IsUnique();

                    b.ToTable("BookIntroductionEntity");
                });

            modelBuilder.Entity("FictionFantasyServer.Data.Entities.CharacterEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Background");

                    b.Property<DateTime>("Created");

                    b.Property<string>("FullName");

                    b.Property<int>("Gender");

                    b.Property<DateTime?>("Modified");

                    b.Property<string>("Nickname");

                    b.Property<string>("Occupation");

                    b.Property<int>("Orientation");

                    b.HasKey("Id");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("FictionFantasyServer.Data.Entities.NationalitiesEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description");

                    b.Property<DateTime?>("Modified");

                    b.Property<string>("Name");

                    b.Property<bool>("Persecuted");

                    b.HasKey("Id");

                    b.ToTable("Nationalities");
                });

            modelBuilder.Entity("FictionFantasyServer.Data.Entities.SettingsEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description");

                    b.Property<int>("Historical");

                    b.Property<DateTime?>("Modified");

                    b.Property<string>("Name");

                    b.Property<string>("Vibe");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("FictionFantasyServer.Data.Entities.SpeciesEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description");

                    b.Property<DateTime?>("Modified");

                    b.Property<string>("Name");

                    b.Property<bool>("Persecuted");

                    b.Property<int>("Stature");

                    b.HasKey("Id");

                    b.ToTable("Species");
                });

            modelBuilder.Entity("FictionFantasyServer.Data.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Email");

                    b.Property<string>("FamilyName");

                    b.Property<string>("GivenName");

                    b.Property<DateTime?>("Modified");

                    b.Property<string>("ProfileDescription");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FictionFantasyServer.Data.Entities.BookCharacterEntity", b =>
                {
                    b.HasOne("FictionFantasyServer.Data.Entities.BookEntity", "Book")
                        .WithMany("BookCharacters")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FictionFantasyServer.Data.Entities.CharacterEntity", "Character")
                        .WithMany("BookCharacters")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FictionFantasyServer.Data.Entities.BookEntity", b =>
                {
                    b.HasOne("FictionFantasyServer.Data.Entities.UserEntity", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FictionFantasyServer.Data.Entities.BookIntroductionEntity", b =>
                {
                    b.HasOne("FictionFantasyServer.Data.Entities.BookEntity", "Book")
                        .WithOne("BookIntroduction")
                        .HasForeignKey("FictionFantasyServer.Data.Entities.BookIntroductionEntity", "BookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
