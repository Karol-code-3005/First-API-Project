using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicAPI.DAL.Dtos.SongDtos
{
    public class SongUpdateDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(0.01, 60.00)]
        public double Duration { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public IEnumerable<string> Playlists { get; set; }
    }
}
