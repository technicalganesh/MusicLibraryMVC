using System.Collections.Generic;
using Music.Standards;

namespace Music.Models
{
    public class Composer : EntityBase
    {
        public string Phone { get; set; }
        public virtual HashSet<Album> Albums {get;set;}
    }
}