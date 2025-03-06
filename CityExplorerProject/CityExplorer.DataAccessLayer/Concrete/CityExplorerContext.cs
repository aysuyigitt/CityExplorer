using CityExplorer.EntitiesLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityExplorer.DataAccessLayer.Concrete
{
    public class CityExplorerContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost;Database=CityExplorerRDb;Uid=sa;Pwd=aysu123;TrustServerCertificate=True;");

        }

        public DbSet<About> Abouts {  get; set; }
        public DbSet<Attraction> Attractions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<CityDetail> CityDetails { get; set; }
        public DbSet<EventDetail> EventDetails { get; set; }
        public DbSet<CategoryDetail> CategoryDetails { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogDetail> BlogDetails { get; set; }
        public DbSet<Ticket> Tickets { get; set; }  

    }
}
