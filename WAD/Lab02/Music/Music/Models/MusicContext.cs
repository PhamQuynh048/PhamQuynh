using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Music.Models
{
    public class MusicContext : DbContext
    {
        public MusicContext() : base("Music")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AppMusic> Musics { get; set; }
    }
}