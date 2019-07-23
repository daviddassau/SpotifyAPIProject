using Microsoft.EntityFrameworkCore;
using SpotifyAPIPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpotifyAPIPractice.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<SpotifyAlbum> SpotifyAlbums { get; set; }

    }
}
