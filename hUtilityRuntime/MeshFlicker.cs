using UnityEngine;

namespace hUtilityRuntime
{
    public class MeshFlicker : MonoBehaviour
    {
        public bool _off;

        private float _timer;
        public float FlickerFrequency = 4f;

        public MeshRenderer Renderer;
        public float UpDownTime = 3f;

        private void Update()
        {
            _timer += Time.deltaTime;
            if (!_off)
                Renderer.enabled = Mathf.PerlinNoise(Time.time * FlickerFrequency, Time.time * FlickerFrequency) > 0.5f;

            if (!(_timer > UpDownTime)) return;
            _off = !_off;
            Renderer.enabled = !_off;
            _timer = 0f;
        }
    }
}