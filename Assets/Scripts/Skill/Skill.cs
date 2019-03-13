using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stratosphere.Quadrone
{
    public abstract class Skill : MonoBehaviour
    {
        public string SkillName { get; internal set; }
        public int Strength { get; internal set; }
        public string Description { get; internal set; }

        internal abstract void Effect(Character player, Character opponent);

        public void Use(Character player, Character opponent)
        {
            Effect(player, opponent);
        }
    }
}
