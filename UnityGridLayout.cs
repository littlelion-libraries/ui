using System;
using Transforms;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class UnityGridLayout : GridLayoutGroup, ILayout
    {
        private IRectTransform _transform;
        public float Height => preferredHeight;

        public IRectTransform Transform => _transform ??= new UnityRectTransform
        {
            Impl = GetComponent<RectTransform>()
        };

        public float Width => constraint switch
        {
            Constraint.Flexible => padding.left + padding.right + Size(
                RoundUpDivision(transform.childCount, Count(
                    cellSize.y,
                    spacing.y,
                    Transform.Height - padding.top - padding.bottom
                )),
                cellSize.x,
                spacing.x
            ),
            _ => throw new NotImplementedException()
        };

        private static int Count(float cs, float s, float size)
        {
            var count = 0;
            while (cs <= size)
            {
                count++;
                size -= cs + s;
            }

            return count;
        }

        private int RoundUpDivision(int a, int b)
        {
            return (a + b - 1) / b;
        }

        private static float Size(int count, float cs, float s)
        {
            return count * cs + (count - 1) * s;
        }
    }
}