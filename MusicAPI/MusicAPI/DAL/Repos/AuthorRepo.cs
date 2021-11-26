using MusicAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicAPI.DAL.Repos
{
    public class AuthorRepo : IMusicRepo<Author>
    {
        private readonly MusicContext _context;

        public AuthorRepo(MusicContext context)
        {
            _context = context;
        }

        public void Create(Author thing)
        {
            if(thing == null)
            {
                throw new ArgumentNullException(nameof(thing));
            }

            _context.Authors.Add(thing);
        }

        public void Delete(Author thing)
        {
            if(thing == null)
            {
                throw new ArgumentNullException(nameof(thing));
            }
            _context.Authors.Remove(thing);
        }

        public IEnumerable<Author> ReadAll()
        {
            return _context.Authors.ToList();
        }

        public Author ReadById(int id)
        {
            return _context.Authors.FirstOrDefault(x => x.Id == id);
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void Update(Author thing)
        {
            throw new NotImplementedException();
        }
    }
}
