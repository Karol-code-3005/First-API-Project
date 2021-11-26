using MusicAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicAPI.DAL.Repos
{
    public class GenreRepo : IMusicRepo<Genre>
    {
        private readonly MusicContext _context;

        public GenreRepo(MusicContext context)
        {
            _context = context;
        }

        public void Create(Genre thing)
        {
            if (thing == null)
            {
                throw new ArgumentNullException(nameof(thing));
            }

            _context.Genres.Add(thing);
        }

        public void Delete(Genre thing)
        {
            if (thing == null)
            {
                throw new ArgumentNullException(nameof(thing));
            }

            _context.Genres.Remove(thing);
        }

        public IEnumerable<Genre> ReadAll()
        {
            return _context.Genres.ToList();
        }

        public Genre ReadById(int id)
        {
            return _context.Genres.FirstOrDefault(x => x.Id == id);
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void Update(Genre thing)
        {
            throw new NotImplementedException();
        }
    }
}
