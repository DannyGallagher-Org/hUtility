using UnityEngine;
using UnityEngine.AI;

namespace hUtilityRuntime
{
    public class DisplayPath : MonoBehaviour
    {
        private void OnDrawGizmosSelected()
        {
            var nav = GetComponent<NavMeshAgent>();
            if (nav == null || nav.path == null)
                return;

            for (var i = 0; i < nav.path.corners.Length - 1; i++)
                Debug.DrawLine(nav.path.corners[i], nav.path.corners[i + 1], Color.blue);
        }
    }
}