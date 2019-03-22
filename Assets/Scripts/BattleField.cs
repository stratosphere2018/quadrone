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
        private static string PlayerPath { get; set; }
        private static string OpponentPath { get; set; }

        private void Awake()
        {
#if UNITY_EDITOR
            SetPlayerPath("");
            SetOpponentPath("");
            PlayerData.Data = new PlayerData();
#endif
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
            GameObject playerPrefab = Resources.Load(PlayerPath) as GameObject;
            GameObject player = Instantiate(playerPrefab);
            player.transform.position = new Vector3(-3f, -0.44f, 0);
            player.AddComponent<PlayerInput>();
            player.SendMessage("SetSide", Side.Player);
            GameObject opponentPrefab = Resources.Load(OpponentPath) as GameObject;
            GameObject opponent = Instantiate(opponentPrefab);
            opponent.transform.position = new Vector3(3f, -0.44f, 0);
            opponent.transform.localScale = new Vector3(-1f, 1f, 1f);
            opponent.SendMessage("SetSide", Side.Opponent);

            player.GetComponent<CharController>().opponent = opponent.GetComponent<CharController>();
            opponent.GetComponent<CharController>().opponent = player.GetComponent<CharController>();
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

        public bool Movable(CharController cCtrl, Vector2Int pos)
        {
            Side color = GetSide(pos);
            if (color == cCtrl.side) return true;
            return false;
        }

        public static void SetPlayerPath(string path)
        {
            PlayerPath = "Character/TestCharacter"; //path;
        }

        public static void SetOpponentPath(string path)
        {
            OpponentPath = "Character/TestCharacter"; //path;
        }
    }
}
