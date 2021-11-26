using MusicAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicAPI.DAL.Repos
{
    public class SongRepo: IMusicRepo<Song>
    {
        private readonly MusicContext _context;

        public SongRepo(MusicContext context)
        {
            _context = context;
        }

        public void Create(Song thing)
        {
            if (thing == null)
            {
                throw new ArgumentNullException(nameof(thing));
            }

             _context.Songs.Add(thing);
        }

        public void Delete(Song thing)
        {
            if (thing == null)
            {
                throw new ArgumentNullException(nameof(thing));
            }

            _context.Songs.Remove(thing);
        }

        public IEnumerable<Song> ReadAll()
        {
            return _context.Songs.ToList();
        }

        public Song ReadById(int id)
        {
            return _context.Songs.FirstOrDefault(x => x.Id == id);
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void Update(Song thing)
        {
            throw new NotImplementedException();
        }
    }
}
