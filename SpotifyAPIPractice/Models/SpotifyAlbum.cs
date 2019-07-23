using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpotifyAPIPractice.Models
{
    public class SpotifyAlbum
    {
        public int Id { get; set; }
        public string Album { get; set; }
        public string Label { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
