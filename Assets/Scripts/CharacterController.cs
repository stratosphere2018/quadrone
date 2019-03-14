using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stratosphere.Quadrone
{
    /// <summary>
    /// バトルでのキャラクター操作
    /// </summary>
    public class CharacterController : MonoBehaviour
    {
        private Vector2 _position;

        public Vector2 Position { get => _position; private set => _position = value; }

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
                _position.x += 1;
            }
            else if (input.x < 0)
            {
                _position.x -= 1;
            }
        }
    }
}
