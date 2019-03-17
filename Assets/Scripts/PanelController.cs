using UnityEngine;

namespace Stratosphere.Quadrone
{
    public class PanelController : MonoBehaviour
    {
        public Side DefaultPanelColor { get; private set; }
        public Side CurrentPanelColor { get; set; }
        public PanelState State { get; set; }

        private void Update()
        {
            SpriteRenderer renderer = GetComponent<SpriteRenderer>();
            if (CurrentPanelColor == Side.Player)
            {
                renderer.color = Color.red;
            }
            else
            {
                renderer.color = Color.blue;
            }
        }

        public void SetDefaultSide(Side color)
        {
            DefaultPanelColor = color;
            CurrentPanelColor = color;
            State = PanelState.Normal;
        }
    }
}
