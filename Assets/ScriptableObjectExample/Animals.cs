using UnityEngine;

namespace ScriptableObjectExample
{
	[CreateAssetMenu(menuName = "Animals/AnimalList", fileName = "AnimalList", order = 0)]
	public class Animals : ScriptableObject
	{
		[SerializeReference, SubclassSelector]
		public IAnimal[] AnimalsList;
	}
}