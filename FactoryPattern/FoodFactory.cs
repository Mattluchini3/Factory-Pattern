using System;
namespace FactoryPattern
{
	public static class FoodFactory
	{
		public static IRestuarant GetRestuarant(int sides)
		{
			switch (sides)
			{
				case 1:
					return new Sides();
				case 2:
					return new Steaks();
				default:
					return new Steaks();
			}
		}
    }
}

