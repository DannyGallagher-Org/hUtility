using System;
using UnityEngine;

namespace hUtility.Editor
{
    public static class CustomEditorUtility
    {
        public static void PlantHorizontal(Action action)
        {
            GUILayout.BeginHorizontal();
            action();
            GUILayout.EndHorizontal();
        }

        public static void PlantVertical(Action action)
        {
            GUILayout.BeginVertical();
            action();
            GUILayout.EndVertical();
        }
    }
}