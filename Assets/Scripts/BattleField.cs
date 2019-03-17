using System;
using UnityEngine;

namespace Stratosphere.Quadrone
{
    public class BattleField : MonoBehaviour
    {
        private const int areaXLength = 6;
        private const int areaYLength = 3;

        public GameObject panel;

        public static int AreaXLength => areaXLength;
        public static int AreaYLength => areaYLength;
        private GameObject[,] Panels { get; set; }

        private void Awake()
        {
            Panels = new GameObject[AreaXLength, AreaYLength];
            for (int i = 0; i < AreaXLength; i++)
            {
                for (int j = 0; j < AreaYLength; j++)
                {
                    Panels[i, j] = Instantiate(panel, transform);
                    Vector3 tmp = new Vector3(-5f + i * 2f, -j * 1.32f, 0f);
                    Panels[i, j].transform.position = tmp;
                    PanelController pCtrl = Panels[i, j].GetComponent<PanelController>();
                    if (i < 3)
                    {
                        pCtrl.SetDefaultSide(Side.Player);
                    }
                    else
                    {
                        pCtrl.SetDefaultSide(Side.Opponent);
                    }
                }
            }
        }

        public Side GetSide(int x, int y)
        {
            if (x < 0 || AreaXLength <= x || y < 0 || AreaYLength <= y) return Side.None;
            return Panels[x, y].GetComponent<PanelController>().CurrentPanelColor;
        }

        public Side GetSide(Vector2Int pos)
        {
            return GetSide(pos.x, pos.y);
        }
    }
}
