using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stratosphere.Quadrone
{
    public abstract partial class Character : MonoBehaviour
    {
        public string CharName { get; internal set; }

        public abstract void Animate(CharAnimType type);
    }
}
