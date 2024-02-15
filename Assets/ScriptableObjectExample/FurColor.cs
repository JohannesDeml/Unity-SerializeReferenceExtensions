using UnityEngine;

namespace ScriptableObjectExample
{
	[CreateAssetMenu(menuName = "Animals/FurColor", fileName = "FurColor", order = 0)]
	public class FurColor : ScriptableObject
	{
		public Color color;
	}
}