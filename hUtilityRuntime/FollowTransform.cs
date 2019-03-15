using UnityEngine;

namespace hUtilityRuntime
{
    [ExecuteInEditMode]
    public class FollowTransform : MonoBehaviour
    {
        public Vector3 Offset = Vector3.one;
        public Transform Transform;

        private void Update()
        {
            if (Transform)
                transform.position = Transform.position + Offset;
        }
    }
}