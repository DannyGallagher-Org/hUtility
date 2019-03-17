/*
 * Copyright (c) House of Wire 2017 
 * CallUnityEventOnStart 
 * by Danny Gallagher on 22/11/2017
 */

using UnityEngine;
using UnityEngine.Events;

namespace hUtility
{
    public class CallUnityEventOnStart : MonoBehaviour
    {
        #region Interface

        public UnityEvent Event;
    
        #endregion

        private bool _raised = false;
        
        #region Unity Methods

        private void Start()
        {
            if (!_raised)
            {
                _raised = true;
                Event?.Invoke();
            }
        }

        #endregion

        #region Private Variables

        #endregion

        #region Private Methods

        #endregion
    }
}