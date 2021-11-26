using Microsoft.EntityFrameworkCore;
using MusicAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicAPI.DAL
{
    public class MusicContext : DbContext
    {
        public MusicContext(DbContextOptions<MusicContext> options): base(options)
        {
        }

        public DbSet<Song> Songs { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedAuthor();
            modelBuilder.SeedGenre();
            modelBuilder.SeedSongs();
            modelBuilder.SeedPlayLists();
        }
    }
}
