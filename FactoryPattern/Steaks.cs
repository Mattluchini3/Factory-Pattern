using System;
namespace FactoryPattern
{
	public class Steaks : IRestuarant
	{
		public Steaks()
		{
		}

		public void Food()
		{
			Console.WriteLine("The steak for tonight is a 8oz Wagyu Filet.");
		}
	}
}

