using Transforms;

namespace UI
{
    public interface ILayout
    {
        float Height { get; }
        IRectTransform Transform { get; }
        float Width { get; }
    }
}