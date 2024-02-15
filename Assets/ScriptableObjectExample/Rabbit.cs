using System;
using System.Collections.Generic;

namespace ScriptableObjectExample
{
	[Serializable]
	public class Rabbit : IAnimal
	{
		public Food Food;
		public List<FurColor> FurColors;
	}
}