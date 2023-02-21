using System;
namespace FactoryPattern
{
	public class Sides : IRestuarant
	{
		public Sides()
		{
		}

		public void Food()
		{
			Console.WriteLine("The side for tonight is potato puree with sauteed spinach");
		}
	}
}

