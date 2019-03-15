using UnityEngine;

namespace hUtilityRuntime
{
    public class RiseAndSpin : MonoBehaviour
    {
        public float MaxUp = 12.4f;
        public float RotateSpeed = 1f;
        public float UpSpeed = 1f;

        private void Update()
        {
            if (transform.position.y < MaxUp)
                transform.Translate(Vector3.up * UpSpeed);

            transform.Rotate(Vector3.up * Time.deltaTime * RotateSpeed, Space.World);
        }
    }
}