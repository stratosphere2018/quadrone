using UnityEngine;

namespace Stratosphere.Quadrone
{
    [RequireComponent(typeof(CharController))]
    public class PlayerInput : MonoBehaviour
    {
        private CharController player;

        public bool Moved { get; set; }

        private void Start()
        {
            player = GetComponent<CharController>();
        }

        private void Update()
        {
            Vector2 PoV = InputExt.PoVAxis;
            if (PoV.magnitude > 0)
            {
                if (!Moved)
                {
                    Vector2Int move = new Vector2Int(0, 0);
                    if (PoV.x > 0) move.x++;
                    if (PoV.x < 0) move.x--;
                    if (PoV.y > 0) move.y++;
                    if (PoV.y < 0) move.y--;
                    player.MoveInput(move);
                    Moved = true;
                }
            }
            else
            {
                Moved = false;
            }
            if (InputExt.Button00Up)
            {
                // バスター
            }
            if (InputExt.Button00Down)
            {
                //バスターチャージ
            }
        }
    }
}
