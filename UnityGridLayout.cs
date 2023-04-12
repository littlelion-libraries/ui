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

        public float Width => preferredWidth;
    }
}