using System.Collections;
using RSG;
using UnityEngine;

namespace hUtilityRuntime.PResources
{
    public static class PResources
    {
        public static IPromise<AudioClip> LoadAudioClipFromStreamingAssets(string path)
        {
            var promise = new Promise<AudioClip>();

            StaticCoroutinableObject.StartACoroutine(LoadAudioClipFromStreamingAssetsCoroutine(path, promise));

            return promise;
        }

        private static IEnumerator LoadAudioClipFromStreamingAssetsCoroutine(string path,
            IPendingPromise<AudioClip> promise)
        {
            using (var www = new WWW(path))
            {
                yield return www;

                if (!string.IsNullOrEmpty(www.error))
                {
                    Debug.LogWarning($"Failed: {path} \n\n error:{www.error}");
                }
                else
                {
                    var clip = www.GetAudioClip();
                    promise.Resolve(clip);
                }
            }
        }
    }
}