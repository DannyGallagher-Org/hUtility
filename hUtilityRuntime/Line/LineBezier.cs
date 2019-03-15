using UnityEngine;

namespace hUtilityRuntime.Line
{
    public class LineBezier : MonoBehaviour
    {
        public Vector3[] Points;

        public Vector3 GetPoint(float t)
        {
            return transform.TransformPoint(Bezier.GetPoint(Points[0], Points[1], Points[2], t));
        }

        public void Reset()
        {
            Points = new[]
            {
                new Vector3(0, 0, 0),
                new Vector3(0, 1, 0),
                new Vector3(0, 2, 0)
            };
        }
    }
}