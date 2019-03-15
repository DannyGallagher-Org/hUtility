using UnityEngine;

namespace hUtilityRuntime
{
    public class ObjectFlicker : MonoBehaviour
    {
        public bool _off;

        private float _timer;
        public float FlickerFrequency = 4f;

        public GameObject[] FlickerTargets;
        public float UpDownTime = 3f;

        private void Update()
        {
            _timer += Time.deltaTime;
            if (!_off)
            {
                foreach (var target in FlickerTargets)
                    target.SetActive(Mathf.PerlinNoise(Time.time * FlickerFrequency, Time.time * FlickerFrequency) > 0.5f);
            }

            if (!(_timer > UpDownTime)) return;
            _off = !_off;
            
            foreach (var target in FlickerTargets)
                target.SetActive(!_off);
            
            _timer = 0f;
        }
    }
}