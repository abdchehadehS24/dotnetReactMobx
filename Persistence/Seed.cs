using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
         public static async Task SeedData(DataContext context)
        {
            if (context.Items.Any()) return;
            
            var items = new List<Item>
            {
                new Item
                {
                    Title = "Past Item 1",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "Item 2 months ago",
                    Category = "drinks",
                    City = "London",
                    Venue = "Pub",
                },
                new Item
                {
                    Title = "Past Item 2",
                    Date = DateTime.Now.AddMonths(-1),
                    Description = "Item 1 month ago",
                    Category = "culture",
                    City = "Paris",
                    Venue = "Louvre",
                },
                new Item
                {
                    Title = "Future Item 1",
                    Date = DateTime.Now.AddMonths(1),
                    Description = "Item 1 month in future",
                    Category = "culture",
                    City = "London",
                    Venue = "Natural History Museum",
                },
                new Item
                {
                    Title = "Future Item 2",
                    Date = DateTime.Now.AddMonths(2),
                    Description = "Item 2 months in future",
                    Category = "music",
                    City = "London",
                    Venue = "O2 Arena",
                },
                new Item
                {
                    Title = "Future Item 3",
                    Date = DateTime.Now.AddMonths(3),
                    Description = "Item 3 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Another pub",
                },
                new Item
                {
                    Title = "Future Item 4",
                    Date = DateTime.Now.AddMonths(4),
                    Description = "Item 4 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Yet another pub",
                },
                new Item
                {
                    Title = "Future Item 5",
                    Date = DateTime.Now.AddMonths(5),
                    Description = "Item 5 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Just another pub",
                },
                new Item
                {
                    Title = "Future Item 6",
                    Date = DateTime.Now.AddMonths(6),
                    Description = "Item 6 months in future",
                    Category = "music",
                    City = "London",
                    Venue = "Roundhouse Camden",
                },
                new Item
                {
                    Title = "Future Item 7",
                    Date = DateTime.Now.AddMonths(7),
                    Description = "Item 2 months ago",
                    Category = "travel",
                    City = "London",
                    Venue = "Somewhere on the Thames",
                },
                new Item
                {
                    Title = "Future Item 8",
                    Date = DateTime.Now.AddMonths(8),
                    Description = "Item 8 months in future",
                    Category = "film",
                    City = "London",
                    Venue = "Cinema",
                }
            };

            await context.Items.AddRangeAsync(items);
            await context.SaveChangesAsync();
        }
    }
}
