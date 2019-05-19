using UnityEngine;

namespace hUtility.ScriptableVariables.FutureGO
{
	public class FutureGoReference : MonoBehaviour
	{
		public FutureGoVariable GameObject;

		public bool Value(out GameObject oGameObject)
		{
			oGameObject = GameObject.Value;
			return GameObject;
		}
	}
}
