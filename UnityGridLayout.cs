using UnityEngine.UI;

namespace UI
{
    public class UnityGridLayout : GridLayoutGroup, ILayout
    {
        public float Height { get => preferredHeight; }
        public float Width { get => preferredWidth; }
    }
}