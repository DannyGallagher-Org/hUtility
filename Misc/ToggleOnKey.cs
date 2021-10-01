using UnityEngine;

namespace hUtility
{
    public class ToggleOnKey : MonoBehaviour
    {
        public KeyCode Key;
        public bool StartOff = true;
        public GameObject Target;

        private void Awake()
        {
            if (StartOff) Target.SetActive(false);
        }

        private void Update()
        {
            if (UnityEngine.Input.GetKeyDown(Key))
                Target.SetActive(!Target.activeSelf);
        }
    }
}