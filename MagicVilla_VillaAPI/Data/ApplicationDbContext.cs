using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Villa> Villas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "My employer has been great to work for, and we have achieved many productive things whilst I have been working there.",
                    ImageUrl = "https://www.booking.com/hotel/ng/the-retreat-sangotedo.en-gb.html?aid=303948&label=sangotedo-apFnh3uy8KNx8xxrsqblXAS528791914267%3Apl%3Ata%3Ap12%3Ap2%3Aac%3Aap%3Aneg%3Afi%3Atikwd-233752489278%3Alp9073716%3Ali%3Adec%3Adm%3Appccp%3DUmFuZG9tSVYkc2RlIyh9Yf5EcukO1MOGLSSAuId8ToA&sid=a106f137968291ceaec8484455dfcbbf&dest_id=-2026094&dest_type=city&dist=0&group_adults=2&group_children=0&hapos=1&hpos=1&no_rooms=1&req_adults=2&req_children=0&room1=A%2CA&sb_price_type=total&sr_order=popularity&srepoch=1668543595&srpvid=88468ef42c9f027c&type=total&ucfs=1&activeTab=photosaGallery",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "",
                    CreatedDate = DateTime.Now

                },
                new Villa
                {
                    Id = 2,
                    Name = "Blue Moon",
                    Details = "My strengths include learning new things quickly and completing all tasks as per the required brief. I am commercially/technically aware which means I understand my responsibilities in this ",
                    ImageUrl = "https://www.booking.com/hotel/ng/the-retreat-sangotedo.en-gb.html?aid=303948&label=sangotedo-apFnh3uy8KNx8xxrsqblXAS528791914267%3Apl%3Ata%3Ap12%3Ap2%3Aac%3Aap%3Aneg%3Afi%3Atikwd-233752489278%3Alp9073716%3Ali%3Adec%3Adm%3Appccp%3DUmFuZG9tSVYkc2RlIyh9Yf5EcukO1MOGLSSAuId8ToA&sid=a106f137968291ceaec8484455dfcbbf&dest_id=-2026094&dest_type=city&dist=0&group_adults=2&group_children=0&hapos=1&hpos=1&no_rooms=1&req_adults=2&req_children=0&room1=A%2CA&sb_price_type=total&sr_order=popularity&srepoch=1668543595&srpvid=88468ef42c9f027c&type=total&ucfs=1&activeTab=photosaGallery",
                    Occupancy = 30,
                    Rate = 300,
                    Sqft = 730,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa
                {
                    Id = 3,
                    Name = "Mosafuneto Villa",
                    Details = "I am great with people, I always put the needs of a team first and I will always take on duties that are outside the job description.",
                    ImageUrl = "https://www.booking.com/hotel/ng/the-retreat-sangotedo.en-gb.html?aid=303948&label=sangotedo-apFnh3uy8KNx8xxrsqblXAS528791914267%3Apl%3Ata%3Ap12%3Ap2%3Aac%3Aap%3Aneg%3Afi%3Atikwd-233752489278%3Alp9073716%3Ali%3Adec%3Adm%3Appccp%3DUmFuZG9tSVYkc2RlIyh9Yf5EcukO1MOGLSSAuId8ToA&sid=a106f137968291ceaec8484455dfcbbf&dest_id=-2026094&dest_type=city&dist=0&group_adults=2&group_children=0&hapos=1&hpos=1&no_rooms=1&req_adults=2&req_children=0&room1=A%2CA&sb_price_type=total&sr_order=popularity&srepoch=1668543595&srpvid=88468ef42c9f027c&type=total&ucfs=1&activeTab=photosaGallery",
                    Occupancy = 45,
                    Rate = 130,
                    Sqft = 213,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa
                {
                    Id = 4,
                    Name = "Diamond Villa",
                    Details = "my biggest weakness is the fact that I find it hard to say no to people that need help. I tend to say yes to everything and I end up taking on too many responsibilities. I never let people down",
                    ImageUrl = "https://www.booking.com/hotel/ng/the-retreat-sangotedo.en-gb.html?aid=303948&label=sangotedo-apFnh3uy8KNx8xxrsqblXAS528791914267%3Apl%3Ata%3Ap12%3Ap2%3Aac%3Aap%3Aneg%3Afi%3Atikwd-233752489278%3Alp9073716%3Ali%3Adec%3Adm%3Appccp%3DUmFuZG9tSVYkc2RlIyh9Yf5EcukO1MOGLSSAuId8ToA&sid=a106f137968291ceaec8484455dfcbbf&dest_id=-2026094&dest_type=city&dist=0&group_adults=2&group_children=0&hapos=1&hpos=1&no_rooms=1&req_adults=2&req_children=0&room1=A%2CA&sb_price_type=total&sr_order=popularity&srepoch=1668543595&srpvid=88468ef42c9f027c&type=total&ucfs=1&activeTab=photosaGallery",
                    Occupancy = 7,
                    Rate = 50,
                    Sqft = 100,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa
                {
                    Id = 5,
                    Name = "Bethsida Hotel",
                    Details = "I would always try to resolve the conflict by myself as a mature and professional employee. I would always put the interest of the team first and I won’t include my manager unless absolutely necessary.",
                    ImageUrl = "https://www.booking.com/hotel/ng/the-retreat-sangotedo.en-gb.html?aid=303948&label=sangotedo-apFnh3uy8KNx8xxrsqblXAS528791914267%3Apl%3Ata%3Ap12%3Ap2%3Aac%3Aap%3Aneg%3Afi%3Atikwd-233752489278%3Alp9073716%3Ali%3Adec%3Adm%3Appccp%3DUmFuZG9tSVYkc2RlIyh9Yf5EcukO1MOGLSSAuId8ToA&sid=a106f137968291ceaec8484455dfcbbf&dest_id=-2026094&dest_type=city&dist=0&group_adults=2&group_children=0&hapos=1&hpos=1&no_rooms=1&req_adults=2&req_children=0&room1=A%2CA&sb_price_type=total&sr_order=popularity&srepoch=1668543595&srpvid=88468ef42c9f027c&type=total&ucfs=1&activeTab=photosaGallery",
                    Occupancy = 32,
                    Rate = 70,
                    Sqft = 450,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                }
                );
        }
    }
}
