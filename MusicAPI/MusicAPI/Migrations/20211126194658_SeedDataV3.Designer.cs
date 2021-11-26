﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicAPI.DAL;

namespace MusicAPI.Migrations
{
    [DbContext(typeof(MusicContext))]
    [Migration("20211126194658_SeedDataV3")]
    partial class SeedDataV3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MusicAPI.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Yanni"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sabaton"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Lady GaGa"
                        });
                });

            modelBuilder.Entity("MusicAPI.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pop"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Classic"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Power metal"
                        });
                });

            modelBuilder.Entity("MusicAPI.Models.Playlist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Playlists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Relax playlist"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Workout playlist"
                        });
                });

            modelBuilder.Entity("MusicAPI.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<double>("Duration")
                        .HasColumnType("float");

                    b.Property<int?>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("GenreId");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Duration = 3.1499999999999999,
                            Name = "Poker face"
                        },
                        new
                        {
                            Id = 2,
                            Duration = 3.0499999999999998,
                            Name = "50:1"
                        },
                        new
                        {
                            Id = 3,
                            Duration = 3.3500000000000001,
                            Name = "Nightingale"
                        },
                        new
                        {
                            Id = 4,
                            Duration = 5.1500000000000004,
                            Name = "End of August"
                        },
                        new
                        {
                            Id = 5,
                            Duration = 2.5,
                            Name = "Cliff of Galipoli"
                        },
                        new
                        {
                            Id = 6,
                            Duration = 3.1499999999999999,
                            Name = "Carolus Rex"
                        },
                        new
                        {
                            Id = 7,
                            Duration = 3.2999999999999998,
                            Name = "The Last Stand"
                        },
                        new
                        {
                            Id = 8,
                            Duration = 2.4500000000000002,
                            Name = "Look what I found"
                        },
                        new
                        {
                            Id = 9,
                            Duration = 4.0,
                            Name = "Alejandro"
                        },
                        new
                        {
                            Id = 10,
                            Duration = 4.25,
                            Name = "One's man dream"
                        },
                        new
                        {
                            Id = 11,
                            Duration = 4.3499999999999996,
                            Name = "Felitsa"
                        });
                });

            modelBuilder.Entity("PlaylistSong", b =>
                {
                    b.Property<int>("PlaylistsId")
                        .HasColumnType("int");

                    b.Property<int>("SongsId")
                        .HasColumnType("int");

                    b.HasKey("PlaylistsId", "SongsId");

                    b.HasIndex("SongsId");

                    b.ToTable("PlaylistSong");
                });

            modelBuilder.Entity("MusicAPI.Models.Song", b =>
                {
                    b.HasOne("MusicAPI.Models.Author", "Author")
                        .WithMany("Songs")
                        .HasForeignKey("AuthorId");

                    b.HasOne("MusicAPI.Models.Genre", "Genre")
                        .WithMany("Songs")
                        .HasForeignKey("GenreId");

                    b.Navigation("Author");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("PlaylistSong", b =>
                {
                    b.HasOne("MusicAPI.Models.Playlist", null)
                        .WithMany()
                        .HasForeignKey("PlaylistsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicAPI.Models.Song", null)
                        .WithMany()
                        .HasForeignKey("SongsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MusicAPI.Models.Author", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("MusicAPI.Models.Genre", b =>
                {
                    b.Navigation("Songs");
                });
#pragma warning restore 612, 618
        }
    }
}
