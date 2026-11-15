using Microsoft.EntityFrameworkCore;
using static EFCore02.BadgeClass;

namespace EFCore02
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var organizer = new OrganizerClass
            {
                Name = "Sarah Jenkins",
                CompanyName = "TechWave Ltd.",
                IsVerified = true,
                Profile = new OrgnizerProfileClass
                {
                    Biography = "Organizing developer conferences since 2018.",
                    Link = "https://techwave.example.com",
                    logo = "https://techwave.example.com/logo.png"
                },
                Events = new List<Event>
            {

        new()
        {
            Title = "EF Core Deep Dive",
            Desc = "Hands-on workshop covering data modeling and performance.",
            StartDate = DateTime.UtcNow.AddDays(30),
            EndDate = DateTime.UtcNow.AddDays(31),
            MaximumNumberOfAttendees = 150
        }
        }
            };
            var attendee = new AttendeeClass
            {
                FName = "Omar Hassan",
                Email = "omar@example.com",
                Street = "14 Nile St",
                City = "Cairo",
                Country = "Egypt",
                PostalCode = "11511",
                badge = new BadgeClass
                {
                    BadgeNumber = $"BDG-{Guid.NewGuid().ToString()[..8].ToUpper()}",
                    IssuedDate = DateTime.UtcNow,
                    Tier = BadgeTier.VIP
                }
            };

            //SaveChanges();

            Console.WriteLine($"Organizer saved (Id={organizer.Id}) with {organizer.Events.Count} event(s).");
            Console.WriteLine($"Attendee: {attendee.FName} | Address: {attendee.FullAddress} | Badge: {attendee.badge.BadgeNumber}");
        }
    }
}
