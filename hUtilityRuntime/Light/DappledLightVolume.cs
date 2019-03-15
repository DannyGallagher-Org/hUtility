using UnityEngine;

namespace hUtilityRuntime.Light
{
    public class DappledLightVolume : MonoBehaviour
    {
        public UnityEngine.Light Light;
        private UnityEngine.Light _shioriLight;

        private void Awake()
        {
            _shioriLight = FindObjectOfType<ShiorisDirectionalLight>().GetComponent<UnityEngine.Light>();
        }

        private void OnTriggerEnter(Collider other)
        {
            _shioriLight = FindObjectOfType<ShiorisDirectionalLight>().GetComponent<UnityEngine.Light>();
            _shioriLight.gameObject.SetActive(false);
            Light.gameObject.SetActive(true);
        }

        private void OnTriggerExit(Collider other)
        {
            _shioriLight.gameObject.SetActive(true);
            Light.gameObject.SetActive(false);
        }
    }
}