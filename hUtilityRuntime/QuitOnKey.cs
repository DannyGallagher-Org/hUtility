/*
 * Copyright (c) House of Wire 2017 
 * QuitOnKey 
 * by Danny Gallagher on 08/12/2017
 */

using UnityEngine;

namespace hUtilityRuntime
{
    public class QuitOnKey : MonoBehaviour
    {
        #region Interface

        public KeyCode Quit = KeyCode.Escape;

        #endregion

        #region Unity Methods

        private void Update()
        {
            if (UnityEngine.Input.GetKey(Quit))
                Application.Quit();
        }

        #endregion

        #region Private Variables

        #endregion

        #region Private Methods

        #endregion
    }
}