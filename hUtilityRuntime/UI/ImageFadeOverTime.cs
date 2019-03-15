/*
 * Copyright (c) House of Wire 2017 
 * ImageFadeOverTime 
 * by Danny Gallagher on 22/11/2017
 */

using UnityEngine;
using UnityEngine.UI;

namespace hUtilityRuntime.UI
{
    public class ImageFadeOverTime : MonoBehaviour
    {
        #region Interface

        public float ImageFadeDelay;
        public float ImageFadeTime;

        public bool DisableAfterFade;

        #endregion

        #region Private Variables

        private float _timeElapsed;
        private Image _image;

        #endregion

        #region Unity Methods

        private void Awake()
        {
            _image = GetComponent<Image>();
        }

        private void Update()
        {
            if (!gameObject.activeSelf) return;

            _timeElapsed += Time.deltaTime;

            if (_timeElapsed > ImageFadeDelay)
                _image.color = _image.color - new Color(0f, 0f, 0f, 1f * Time.deltaTime / ImageFadeTime);

            if (!(_timeElapsed > ImageFadeDelay + ImageFadeTime)) return;
            if (DisableAfterFade)
                gameObject.SetActive(false);
        }

        #endregion

        #region Private Methods

        #endregion
    }
}