using System;
using Music.Standards;

namespace Music.Models
{
    public class Album : EntityBase
    {
        public string Genre { get; set; }
        public int ComposerId { get; set; }
        public virtual Composer Composer {get;set;}
    }
}
