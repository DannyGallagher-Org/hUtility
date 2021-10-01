using UnityEngine;

namespace hUtility
{
    [ExecuteInEditMode]
    public class SetMaterialColorAlphaToNoiseOverTime : MonoBehaviour
    {
        [Header("Range")] [Range(0f, 1f)] public float Lower;

        public Material Material;
        [Range(0f, 1f)] public float Speed = 0.2f;
        [Range(0f, 1f)] public float Upper = 0.5f;


        private void Update()
        {
            var noise = Mathf.PerlinNoise(Time.time * Speed, Time.time * Speed);
            var newRange = Upper - Lower;
            var sample = noise * newRange / 1f;

            var oldColor = Material.color;
            var newColor = oldColor;
            newColor.a = sample;
            Material.SetColor("_Color", newColor);
        }
    }
}