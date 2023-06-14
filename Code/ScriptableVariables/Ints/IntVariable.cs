using UnityEngine;

namespace hUtility.ScriptableVariables.Ints
{
    [CreateAssetMenu(fileName = "NewIntVar", menuName = "DataVariables/Int")]
    public class IntVariable : ScriptableObject
    {
        public int Value;
    }
}