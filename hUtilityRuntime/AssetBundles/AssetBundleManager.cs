/*
 * Copyright (c) Danny Gallagher 2017 
 * AssetBundleManager House Of Wire
 * by Danny Gallagher on 22/11/2017
 */

using System;
using System.Collections;
using hUtility;
using RSG;
using UnityEngine;
using UnityEngine.Assertions;

namespace hUtilityRuntime.AssetBundles
{
    public static class AssetBundleManager
    {
        #region Public Methods

        public static Promise<AssetBundle> LoadAssetBundle(string bundle)
        {
            var promise = new Promise<AssetBundle>();

            RuntimeCoroutine.Instance.StartCoroutine(OpenBundle(promise, bundle));

            return promise;
        }

        private static IEnumerator OpenBundle(Promise<AssetBundle> promise, string bundleName)
        {
            // Loading asset bundle
            var req = AssetBundle.LoadFromFileAsync($"{Application.streamingAssetsPath}/AssetBundles/{bundleName}");
#if DEBUG
            using (new ExecutionTimer($"LoadAssetBundleFromStreamingAssetsCoroutine asset : {bundleName}", null))
#endif
            {
                yield return req;

                Assert.IsNotNull(req.assetBundle,
                    "AssetBundleLoader : asset bundle wans't loaded from streaming assets");
                Assert.IsNotNull(promise, "No promise handler");

                if (req.assetBundle == null)
                {
                    promise.Reject(new ArgumentNullException(nameof(promise)));
                    yield break;
                }
            }

            promise.Resolve(req.assetBundle);
        }

        #endregion

        #region Private Methods

        #endregion
    }
}