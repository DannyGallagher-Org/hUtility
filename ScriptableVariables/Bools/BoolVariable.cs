using UnityEngine;

namespace hUtility.ScriptableVariables.Bools
{
    [CreateAssetMenu(fileName = "NewBoolVar", menuName = "DataVariables/Bool")]
    public class BoolVariable : ScriptableObject
    {
        public bool Value;
    }
}