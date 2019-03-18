﻿using Stratosphere.Quadrone.Character;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stratosphere.Quadrone
{
    public delegate int CharAnimate(CharAnimType type);

    [RequireComponent(typeof(CharController))]
    [DisallowMultipleComponent]
    public abstract class CharacterContainer : MonoBehaviour
    {
        public CharName Name { get; internal set; }
        public int Hp { get; internal set; }
        public CharAnimate Animate { get; internal set; }

        private void Awake()
        {
            GetComponent<CharController>().character = this;
        }
    }
}
