using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanyPieShop.Model
{
    public static class DbInitializer
    {
		public static void Seed(AppDbContext context)
		{
			if (!context.Pies.Any())
			{
				context.AddRange
					(
					new Pie {Name = "Apple Pie",Price = 12.95M,ShortDescription = "Apple pies",LongDescription = "Icing carrot jelly-o cheesecake. Sweet roll marzipa"},
					new Pie { Name = "Lemon Pie", Price = 15.95M, ShortDescription = "Lemon pies", LongDescription = "Icing carrot jelly-o cheesecake. Sweet roll marzipa" },
					new Pie { Name = "Grape Pie", Price = 16.95M, ShortDescription = "Grape pies", LongDescription = "Icing carrot jelly-o cheesecake. Sweet roll marzipa" },
					new Pie { Name = "Banana Pie", Price = 17.95M, ShortDescription = "Banana pies", LongDescription = "Icing carrot jelly-o cheesecake. Sweet roll marzipa" },
					new Pie { Name = "Orange Pie", Price = 18.95M, ShortDescription = "Orange pies", LongDescription = "Icing carrot jelly-o cheesecake. Sweet roll marzipa" }
					);
				context.SaveChanges();
			}
		}
    }
}
