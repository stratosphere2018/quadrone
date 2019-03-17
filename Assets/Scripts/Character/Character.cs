using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stratosphere.Quadrone
{
    public delegate int CharAnimate(CharAnimType type);

    [RequireComponent(typeof(CharController))]
    public abstract class Character : MonoBehaviour
    {
        public string charName;
        public int hp;
        public CharAnimate Animate;

        private void Awake()
        {
            GetComponent<CharController>().character = this;
        }
    }
}
