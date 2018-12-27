using System.Collections.Generic;
using System.Linq;

namespace BethanyPieShop.Model
{
    public class MockPieRepository : IPieRepository
    {
        private List<Pie> _pies;

        public MockPieRepository()
        {
            if (_pies == null)
                InitializePies();
        }

		private void InitializePies()
		{
			_pies = new List<Pie>
			{
				new Pie
				{
					Id = 1,
					Name = "Apple Pie",
					Price = 12.95M,
					ShortDescription = "apple pies",
					LongDescription = "Icing carrot jelly-o cheesecake. Sweet roll marzipa"
				},

				new Pie
				{
					Id = 2,
					Name = "Blueberry Cheese Cake",
					Price = 18.95M,
					ShortDescription = "bluebbery cheese cake",
					LongDescription = "Icing carrot jelly-o cheesecake. Sweet roll marzipa"
				},

				new Pie
				{
					Id = 3,
					Name = "Cheese Cake",
					Price = 18.95M,
					ShortDescription = "cheese cake",
					LongDescription = "Icing carrot jelly-o cheesecake. Sweet roll marzipa"
				},

				new Pie
				{
					Id = 4,
					Name = "Cherry Pie",
					Price = 15.95M,
					ShortDescription = "cherry pie",
					LongDescription = "Icing carrot jelly-o cheesecake. Sweet roll marzipa"
				}
			};
		}

		public IEnumerable<Pie> GetAllPies()
        {
            return _pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
