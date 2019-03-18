using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stratosphere.Quadrone
{
    [DisallowMultipleComponent]
    public abstract class CardContainer : MonoBehaviour
    {
        public string Name { get; internal set; }
        public int Strength { get; internal set; }
        public string Description { get; internal set; }

        internal abstract void Effect(CharacterContainer executioner, CharacterContainer opponent);

        public void Use(CharacterContainer executioner, CharacterContainer opponent)
        {
            Effect(executioner, opponent);
        }
    }
}
