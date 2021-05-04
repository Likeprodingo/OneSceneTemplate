using UnityEngine.UI;

namespace FoldTheWay.UI
{
    public class EmptyGraphics : MaskableGraphic
    {
        protected override void OnPopulateMesh(VertexHelper vh)
        {
            vh.Clear();
            return;
        }
    }
}