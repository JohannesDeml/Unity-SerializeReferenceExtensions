using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjectExample
{
	[Serializable]
	public class Gazelle : IAnimal
	{
		public Food Food;
		public List<FurColor> FurColors;
	}
}