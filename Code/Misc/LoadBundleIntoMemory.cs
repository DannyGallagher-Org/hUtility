/*
 * Copyright (c) House of Wire 2017 
 * LoadBundleIntoMemory 
 * by Danny Gallagher on 22/11/2017
 */

using System.Collections;
using hUtility.AssetBundles;
using RSG;
using UnityEngine;
using UnityEngine.Events;

namespace hUtility
{
    public class LoadBundleIntoMemory : MonoBehaviour
    {
        #region Public methods

        public void DoLoad()
        {
            AssetBundleManager.LoadAssetBundle(AssetBundle)
                .Then(BundleLoaded)
                .Catch(exception =>
                {
                    var unityException = new UnityException($"{exception}");
                    throw unityException;
                });
        }

        #endregion

        #region Interface

        public UnityEvent OnComplete;
        public string AssetBundle;

        #endregion

        #region Private Variables

        #endregion

        #region Private Methods

        private IPromise BundleLoaded(AssetBundle bundle)
        {
            var promise = new Promise();
            StartCoroutine(LoadAllBundleAssets(bundle, promise));
            return promise;
        }

        private IEnumerator LoadAllBundleAssets(AssetBundle bundle, Promise promise)
        {
            var ge = bundle.LoadAllAssets();


            if (ge == null)
            {
                Debug.Log("null");
                yield return new WaitForEndOfFrame();
            }

            Debug.Log(ge.Length);
            OnComplete?.Invoke();
            promise.Resolve();
        }

        #endregion
    }
}