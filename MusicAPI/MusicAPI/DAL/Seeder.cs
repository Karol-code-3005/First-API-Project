using Microsoft.EntityFrameworkCore;
using MusicAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicAPI.DAL
{
    public static class Seeder
    {

        private  static List<Author> GetSeedAuthors()
        {
            var yanni = new Author
            {
                Id = 1,
                Name = "Yanni",
            };
            var sabaton = new Author
            {
                Id = 2,
                Name = "Sabaton",
            };
            var gaga = new Author
            {
                Id = 3,
                Name = "Lady GaGa",
            };
            var ListOfAuthors = new List<Author>
            {
                yanni,
                sabaton,
                gaga
            };

            return ListOfAuthors;
        }

        private static List<Genre> GetSeedGenres()
        {
            var pop = new Genre
            {
                Id = 1,
                Name = "Pop",
            };
            var classic = new Genre
            {
                Id = 2,
                Name = "Classic"
            };
            var powerMetal = new Genre
            {
                Id = 3,
                Name = "Power metal"
            };
            var ListOfGenres = new List<Genre>
            {
                pop,
                classic,
                powerMetal
            };
            return ListOfGenres;
        }

        private static List<Playlist> GetSeedPlaylists()
        {
            var relax = new Playlist
            {
                Id = 1,
                Name = "Relax playlist",
            };
            var workout = new Playlist
            {
                Id = 2,
                Name = "Workout playlist",
            };
            var ListOfAuthors = new List<Playlist>
            {
                relax,
                workout,
            };

            return ListOfAuthors;
        }

        public static List<Song> GetSongs()
        {

            Song pokerFace = new()
            {
                Id = 1,
                Name = "Poker face",
                Duration = 3.15
            };
            Song fifty = new()
            {
                Id = 2,
                Name = "50:1",
                Duration = 3.05
            };
            Song nightingale = new()
            {
                Id = 3,
                Name = "Nightingale",
                Duration = 3.35
            };
            Song endOfAugust = new()
            {
                Id = 4,
                Name = "End of August",
                Duration = 5.15
            };
            Song cliffOfGalipoli = new()
            {
                Id = 5,
                Name = "Cliff of Galipoli",
                Duration = 2.50
            };
            Song carolusRex = new()
            {
                Id = 6,
                Name = "Carolus Rex",
                Duration = 3.15
            };
            Song lastStand = new()
            {
                Id = 7,
                Name = "The Last Stand",
                Duration = 3.30
            };
            Song lookWhatIFound = new()
            {
                Id = 8,
                Name = "Look what I found",
                Duration = 2.45
            };
            Song alejandro = new()
            {
                Id = 9,
                Name = "Alejandro",
                Duration = 4.00
            };
            Song onesManDream = new()
            {
                Id = 10,
                Name = "One's man dream",
                Duration = 4.25
            };
            Song felitsa = new()
            {
                Id = 11,
                Name = "Felitsa",
                Duration = 4.35
            };

            //pokerFace.Author.Id = 3;
            //pokerFace.Genre.Id = 1;

            //fifty.Author.Id = 2;
            //fifty.Genre.Id = 3;

            //nightingale.Author.Id = 1;
            //nightingale.Genre.Id = 2;

            //endOfAugust.Author.Id = 1;
            //endOfAugust.Genre.Id = 2;

            //cliffOfGalipoli.Author.Id = 2;
            //cliffOfGalipoli.Genre.Id = 3;

            //carolusRex.Author.Id = 2;
            //carolusRex.Genre.Id = 2;

            //lastStand.Author.Id = 2;
            //lastStand.Genre.Id = 3;

            //lookWhatIFound.Author.Id = 3;
            //lookWhatIFound.Genre.Id = 1;

            //alejandro.Author.Id = 3;
            //alejandro.Genre.Id = 1;

            //onesManDream.Author.Id = 1;
            //onesManDream.Genre.Id = 2;

            //felitsa.Author.Id = 1;
            //felitsa.Genre.Id = 2;

            var ListOfSongs = new List<Song>
            {
                pokerFace,
                fifty,
                nightingale,
                endOfAugust,
                cliffOfGalipoli,
                carolusRex,
                lastStand,
                lookWhatIFound,
                alejandro,
                onesManDream,
                felitsa
            };

            return ListOfSongs;
        }

        public static void SeedAuthor(this ModelBuilder model)
        {
            model.Entity<Author>().HasData(GetSeedAuthors());
        }

        public static void SeedGenre(this ModelBuilder model)
        {
            model.Entity<Genre>().HasData(GetSeedGenres());
        }

        public static void SeedSongs(this ModelBuilder model)
        {
            model.Entity<Song>().HasData(GetSongs());
        }

        public static void SeedPlayLists(this ModelBuilder model)
        {
            model.Entity<Playlist>().HasData(GetSeedPlaylists());
        }

    }
}
