using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjectExample
{
	[Serializable]
	public class Tiger : IAnimal
	{
		[SerializeReference, SubclassSelector]
		public List<IAnimal> Prey;
	}
}