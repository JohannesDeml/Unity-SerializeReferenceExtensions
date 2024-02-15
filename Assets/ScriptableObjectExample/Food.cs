using UnityEngine;

namespace ScriptableObjectExample
{
	[CreateAssetMenu(menuName = "Animals/Food", fileName = "Food", order = 0)]
	public class Food : ScriptableObject
	{
		public bool isVegetarian;
		public float kcal;
	}
}