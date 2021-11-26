using MusicAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicAPI.DAL.Repos
{
    public class PlaylistRepo : IMusicRepo<Playlist>
    {
        private readonly MusicContext _context;

        public PlaylistRepo(MusicContext contex)
        {
            _context = contex;
        }

        public void Create(Playlist thing)
        {
            if (thing == null)
            {
                throw new ArgumentNullException(nameof(thing));
            }

            _context.Playlists.Add(thing);
        }

        public void Delete(Playlist thing)
        {
            if (thing == null)
            {
                throw new ArgumentNullException(nameof(thing));
            }

            _context.Playlists.Remove(thing);
        }

        public IEnumerable<Playlist> ReadAll()
        {
            return _context.Playlists.ToList();
        }

        public Playlist ReadById(int id)
        {
            return _context.Playlists.FirstOrDefault(x => x.Id == id);
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void Update(Playlist thing)
        {
            throw new NotImplementedException();
        }
    }
}
