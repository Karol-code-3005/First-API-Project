using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicAPI.Models
{
    public class Song
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(0.01,60.00)]
        public double Duration { get; set; }
        public Author Author { get; set; }
        public Genre Genre { get; set; }
        public IEnumerable<Playlist> Playlists { get; set; }
    }
}
