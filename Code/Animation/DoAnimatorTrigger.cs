/*
 * Copyright (c) Danny Gallagher 2017 
 * DoAnimatorTrigger House Of Wire
 * by Danny Gallagher on 22/11/2017
 */

using UnityEngine;

namespace hUtility.Animation
{
    public class DoAnimatorTrigger : MonoBehaviour
    {
        public Animator Animator;
        public string Trigger = string.Empty;

        public void DoTrigger()
        {
            if (!string.IsNullOrEmpty(Trigger))
                Animator.SetTrigger(Trigger);
        }
    }
}