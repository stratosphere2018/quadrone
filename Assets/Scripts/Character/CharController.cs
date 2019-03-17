using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stratosphere.Quadrone
{
    /// <summary>
    /// バトルでのキャラクター操作
    /// </summary>
    public class PlayerController : MonoBehaviour
    {
        /// <summary>
        /// 現在位置
        /// </summary>
        public Vector2 Position { get; private set; }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            Vector2 input = new Vector2();
            input.Set(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            if (input.x > 0)
            {
                Position.Set(Position.x + 1, Position.y);
            }
            else if (input.x < 0)
            {
                Position.Set(Position.x - 1, Position.y);
            }
        }
    }
}
