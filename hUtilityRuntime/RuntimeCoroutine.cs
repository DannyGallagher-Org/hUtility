/*
 * Copyright (c) House of Wire 2017 
 * RuntimeCoroutine 
 * by Danny Gallagher on 22/11/2017
 */

using System;
using UnityEngine;

namespace hUtilityRuntime
{
    public class RuntimeCoroutine : MonoBehaviour, IDisposable
    {
        private static RuntimeCoroutine _instance;

        public static RuntimeCoroutine Instance
        {
            get
            {
                if (_instance != null) return _instance;

                var newObj = new GameObject();
                var script = newObj.AddComponent<RuntimeCoroutine>();
                _instance = script;

                return _instance;
            }
        }

        public void Dispose()
        {
            var go = _instance.gameObject;
            _instance = null;
            Destroy(go);
        }
    }
}