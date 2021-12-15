using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TranVanTuyen760.Models;

    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<TranVanTuyen760.Models.UniversityTVT760> UniversityTVT760 { get; set; }

        public DbSet<TranVanTuyen760.Models.TVT0760> TVT0760 { get; set; }
    }
