using Transforms;

namespace UI
{
    public interface IScrollRect
    {
        IRectTransform Content { get; }
        bool Horizontal { set; }
        float HorizontalNormalizedPosition { set; }
        bool Vertical { set; }
        float VerticalNormalizedPosition { set; }
    }
}