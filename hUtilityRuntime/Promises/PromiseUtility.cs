using System.Collections;
using RSG;
using UnityEngine;

namespace hUtilityRuntime.Promises
{
    public static class PromiseUtility
    {
        public static Promise WaitForSeconds(float seconds)
        {
            var promise = new Promise();

            StaticCoroutinableObject.StartACoroutine(WaitForSecondsCoroutine(seconds, promise));

            return promise;
        }

        private static IEnumerator WaitForSecondsCoroutine(float seconds, Promise promise)
        {
            yield return new WaitForSeconds(seconds);
            promise.Resolve();
        }
    }
}