using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicAPI.DAL.Dtos
{
    public class ReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<string> Songs { get; set; }
    }
}
