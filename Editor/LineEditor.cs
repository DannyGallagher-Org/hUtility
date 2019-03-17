using UnityEditor;
using UnityEngine;

namespace hUtility.Editor
{
    [CustomEditor(typeof(Line.Line))]
    public class LineEditor : UnityEditor.Editor
    {
        private const string KRecordMovePoint = "Move Point";

        private void OnSceneGUI()
        {
            var line = target as Line.Line;

            if (line != null)
            {
                var handleTransform = line.transform;
                var handleRotation = Tools.pivotRotation == PivotRotation.Local
                    ? handleTransform.rotation
                    : Quaternion.identity;

                var p0 = handleTransform.TransformPoint(line.P0);
                var p1 = handleTransform.TransformPoint(line.P1);

                Handles.color = Color.white;
                Handles.DrawLine(p0, p1);

                Handles.DoPositionHandle(p0, handleRotation);
                Handles.DoPositionHandle(p1, handleRotation);

                EditorGUI.BeginChangeCheck();
                p0 = Handles.DoPositionHandle(p0, handleRotation);
                if (EditorGUI.EndChangeCheck())
                {
                    Undo.RecordObject(line, KRecordMovePoint);
                    EditorUtility.SetDirty(line);
                    line.P0 = handleTransform.InverseTransformPoint(p0);
                }

                EditorGUI.BeginChangeCheck();
                p1 = Handles.DoPositionHandle(p1, handleRotation);
                if (EditorGUI.EndChangeCheck())
                {
                    Undo.RecordObject(line, KRecordMovePoint);
                    EditorUtility.SetDirty(line);
                    line.P1 = handleTransform.InverseTransformPoint(p1);
                }
            }
        }
    }
}