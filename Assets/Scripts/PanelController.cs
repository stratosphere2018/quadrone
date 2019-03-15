using UnityEngine;

namespace Stratosphere.Quadrone
{
    /// <summary>
    /// バトル時のパネル
    /// </summary>
    public class PanelController : MonoBehaviour
    {
        public readonly PanelColor DefaultPanelColor;
        public PanelColor CurrentPanelColor;
        public PanelState State;
    }
}
