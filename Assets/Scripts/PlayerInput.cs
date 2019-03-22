using UnityEngine;

namespace Stratosphere.Quadrone
{
    [RequireComponent(typeof(CharController))]
    public class PlayerInput : MonoBehaviour
    {
        private CharController player;
        private CharController opponent;
        private KeyConfig config;

        public bool Buster { get; set; }


        public bool Moved { get; set; }

        private void Start()
        {
            player = GetComponent<CharController>();
            config = PlayerData.Data.KeyCon;
        }

        private void Update()
        {
            Vector2 PoV = config.Move();
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
            if (config.Attack())
                player.BusterInput();
            if (config.Charge())
                player.Charge();
        }
    }
}
