using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicAPI.DAL
{
    public interface IMusicRepo<T>
    {
        public bool Save();

        public IEnumerable<T> ReadAll();
        public T ReadById(int id);
        public void Create(T thing);
        public void Update(T thing);
        public void Delete(T thing);
    }
}
