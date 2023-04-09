using Transforms;
using UnityEngine.UI;

namespace UI
{
    public class UnityScrollRect : ScrollRect, IScrollRect
    {
        private IRectTransform _content;

        public IRectTransform Content => _content ??= new UnityRectTransform
        {
            Impl = content
        };

        public bool Horizontal
        {
            set => horizontal = value;
        }

        public float HorizontalNormalizedPosition
        {
            set => horizontalNormalizedPosition = value;
        }

        public bool Vertical
        {
            set => vertical = value;
        }

        public float VerticalNormalizedPosition
        {
            set => verticalNormalizedPosition = value;
        }
    }
}