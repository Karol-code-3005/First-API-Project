using MusicAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicAPI.DAL.Dtos.SongDtos
{
    public class SongReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public IEnumerable<string> Playlists { get; set; }
    }
}
