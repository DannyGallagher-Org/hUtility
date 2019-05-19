using UnityEngine;

namespace hUtility.ScriptableVariables.FutureGO
{
	[CreateAssetMenu(fileName = "NewGoVar", menuName = "DataVariables/FutureGo")]
	public class FutureGoVariable : ScriptableObject
	{
		public GameObject Value;
	}
}
