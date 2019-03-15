using UnityEngine;

namespace hUtilityRuntime
{
    public class OffsetPositionWithNoiseSeeded : MonoBehaviour
    {
        private float _seed = 59;
        public float Spread = 1f;
        public float Distance = 0.2f;
        public float Height;
        
        private void Awake()
        {
            _seed = Random.Range(0f, 100f);
        }

        private void Update()
        {
            var height = Height + (Mathf.PerlinNoise(Time.time + _seed, Time.time + _seed) - 0.5f) * Spread;

            transform.localPosition = new Vector3(Mathf.Sin(Time.time)*Distance, height, Mathf.Cos(Time.time)*Distance);
        }
    }
}