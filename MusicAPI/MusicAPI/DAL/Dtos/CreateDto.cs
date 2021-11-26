using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicAPI.DAL.Dtos
{
    public class CreateDto
    {
        [Required]
        public string Name { get; set; }
    }
}
