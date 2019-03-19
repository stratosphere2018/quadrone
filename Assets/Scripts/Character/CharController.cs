using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stratosphere.Quadrone
{
    public class CharController : MonoBehaviour
    {
        public Side side;
        public CharacterContainer character;

        public BattleField Field { get; private set; }
        public Vector2Int Position { get; private set; }


        // Start is called before the first frame update
        void Start()
        {
            Field = GameObject.Find("BattleField").GetComponent<BattleField>();
            if (side == Side.Player)
            {
                Position = new Vector2Int(1, 1);
            }
            else
            {
                Position = new Vector2Int(1, 4);
            }
        }

        // Update is called once per frame
        void Update()
        {
        }

        public void MoveInput(Vector2Int movement)
        {
            Vector2Int next = Position + movement;
            if (0 <= next.x && next.x < BattleField.AreaXLength && 0 <= next.y && next.y < BattleField.AreaYLength && Field.Movable(this, next))
            {
                StartCoroutine("Move", movement);
            }
        }

        IEnumerator Move(Vector2Int movement)
        {
            int i = 0;
            int spd = character.Animate(CharAnimType.Move);
            if (spd < 1) spd = 1;
            Vector3 moveIn3DPos = new Vector3(movement.x * 2f, movement.y * 1.32f);
            while (i++ < spd)
            {
                transform.Translate(moveIn3DPos / spd);
                yield return null;
            }
            Position += movement;
        }

        public void SetSide(Side side)
        {
            this.side = side;
        }

    }
}
