using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    public partial class SeedVillaTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "My employer has been great to work for, and we have achieved many productive things whilst I have been working there.", "https://www.booking.com/hotel/ng/the-retreat-sangotedo.en-gb.html?aid=303948&label=sangotedo-apFnh3uy8KNx8xxrsqblXAS528791914267%3Apl%3Ata%3Ap12%3Ap2%3Aac%3Aap%3Aneg%3Afi%3Atikwd-233752489278%3Alp9073716%3Ali%3Adec%3Adm%3Appccp%3DUmFuZG9tSVYkc2RlIyh9Yf5EcukO1MOGLSSAuId8ToA&sid=a106f137968291ceaec8484455dfcbbf&dest_id=-2026094&dest_type=city&dist=0&group_adults=2&group_children=0&hapos=1&hpos=1&no_rooms=1&req_adults=2&req_children=0&room1=A%2CA&sb_price_type=total&sr_order=popularity&srepoch=1668543595&srpvid=88468ef42c9f027c&type=total&ucfs=1&activeTab=photosaGallery", "Royal Villa", 5, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "My strengths include learning new things quickly and completing all tasks as per the required brief. I am commercially/technically aware which means I understand my responsibilities in this ", "https://www.booking.com/hotel/ng/the-retreat-sangotedo.en-gb.html?aid=303948&label=sangotedo-apFnh3uy8KNx8xxrsqblXAS528791914267%3Apl%3Ata%3Ap12%3Ap2%3Aac%3Aap%3Aneg%3Afi%3Atikwd-233752489278%3Alp9073716%3Ali%3Adec%3Adm%3Appccp%3DUmFuZG9tSVYkc2RlIyh9Yf5EcukO1MOGLSSAuId8ToA&sid=a106f137968291ceaec8484455dfcbbf&dest_id=-2026094&dest_type=city&dist=0&group_adults=2&group_children=0&hapos=1&hpos=1&no_rooms=1&req_adults=2&req_children=0&room1=A%2CA&sb_price_type=total&sr_order=popularity&srepoch=1668543595&srpvid=88468ef42c9f027c&type=total&ucfs=1&activeTab=photosaGallery", "Blue Moon", 30, 300.0, 730, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "I am great with people, I always put the needs of a team first and I will always take on duties that are outside the job description.", "https://www.booking.com/hotel/ng/the-retreat-sangotedo.en-gb.html?aid=303948&label=sangotedo-apFnh3uy8KNx8xxrsqblXAS528791914267%3Apl%3Ata%3Ap12%3Ap2%3Aac%3Aap%3Aneg%3Afi%3Atikwd-233752489278%3Alp9073716%3Ali%3Adec%3Adm%3Appccp%3DUmFuZG9tSVYkc2RlIyh9Yf5EcukO1MOGLSSAuId8ToA&sid=a106f137968291ceaec8484455dfcbbf&dest_id=-2026094&dest_type=city&dist=0&group_adults=2&group_children=0&hapos=1&hpos=1&no_rooms=1&req_adults=2&req_children=0&room1=A%2CA&sb_price_type=total&sr_order=popularity&srepoch=1668543595&srpvid=88468ef42c9f027c&type=total&ucfs=1&activeTab=photosaGallery", "Mosafuneto Villa", 45, 130.0, 213, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "my biggest weakness is the fact that I find it hard to say no to people that need help. I tend to say yes to everything and I end up taking on too many responsibilities. I never let people down", "https://www.booking.com/hotel/ng/the-retreat-sangotedo.en-gb.html?aid=303948&label=sangotedo-apFnh3uy8KNx8xxrsqblXAS528791914267%3Apl%3Ata%3Ap12%3Ap2%3Aac%3Aap%3Aneg%3Afi%3Atikwd-233752489278%3Alp9073716%3Ali%3Adec%3Adm%3Appccp%3DUmFuZG9tSVYkc2RlIyh9Yf5EcukO1MOGLSSAuId8ToA&sid=a106f137968291ceaec8484455dfcbbf&dest_id=-2026094&dest_type=city&dist=0&group_adults=2&group_children=0&hapos=1&hpos=1&no_rooms=1&req_adults=2&req_children=0&room1=A%2CA&sb_price_type=total&sr_order=popularity&srepoch=1668543595&srpvid=88468ef42c9f027c&type=total&ucfs=1&activeTab=photosaGallery", "Diamond Villa", 7, 50.0, 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "I would always try to resolve the conflict by myself as a mature and professional employee. I would always put the interest of the team first and I won’t include my manager unless absolutely necessary.", "https://www.booking.com/hotel/ng/the-retreat-sangotedo.en-gb.html?aid=303948&label=sangotedo-apFnh3uy8KNx8xxrsqblXAS528791914267%3Apl%3Ata%3Ap12%3Ap2%3Aac%3Aap%3Aneg%3Afi%3Atikwd-233752489278%3Alp9073716%3Ali%3Adec%3Adm%3Appccp%3DUmFuZG9tSVYkc2RlIyh9Yf5EcukO1MOGLSSAuId8ToA&sid=a106f137968291ceaec8484455dfcbbf&dest_id=-2026094&dest_type=city&dist=0&group_adults=2&group_children=0&hapos=1&hpos=1&no_rooms=1&req_adults=2&req_children=0&room1=A%2CA&sb_price_type=total&sr_order=popularity&srepoch=1668543595&srpvid=88468ef42c9f027c&type=total&ucfs=1&activeTab=photosaGallery", "Bethsida Hotel", 32, 70.0, 450, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
