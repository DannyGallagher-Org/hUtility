using hUtility.Line;
using UnityEditor;
using UnityEngine;

namespace hUtility.Editor
{
    [CustomEditor(typeof(LineBezier))]
    public class LineBezierEditor : UnityEditor.Editor
    {
        private const string KRecordMoveObject = "Move Pont";

        private const int KLineSteps = 10;

        private LineBezier _curve;
        private Quaternion _handleRotation;
        private Transform _handleTransform;

        private void OnSceneGUI()
        {
            _curve = target as LineBezier;
            if (_curve != null)
            {
                _handleTransform = _curve.transform;
                _handleRotation = Tools.pivotRotation == PivotRotation.Local
                    ? _handleTransform.rotation
                    : Quaternion.identity;

                var p0 = ShowPoint(0);
                var p1 = ShowPoint(1);
                var p2 = ShowPoint(2);

                Handles.color = Color.grey;
                Handles.DrawLine(p0, p1);
                Handles.DrawLine(p1, p2);

                Handles.color = Color.white;
                var lineStart = _curve.GetPoint(0f);
                for (var i = 1; i <= KLineSteps; i++)
                {
                    var lineEnd = _curve.GetPoint(i / (float) KLineSteps);
                    Handles.DrawLine(lineStart, lineEnd);
                    lineStart = lineEnd;
                }
            }
        }

        private Vector3 ShowPoint(int index)
        {
            var point = _handleTransform.TransformPoint(_curve.Points[index]);

            EditorGUI.BeginChangeCheck();
            point = Handles.DoPositionHandle(point, _handleRotation);
            if (EditorGUI.EndChangeCheck())
            {
                Undo.RecordObject(_curve, KRecordMoveObject);
                EditorUtility.SetDirty(_curve);
                _curve.Points[index] = _handleTransform.InverseTransformPoint(point);
            }

            return point;
        }
    }
}