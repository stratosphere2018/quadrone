using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stratosphere.Quadrone
{
    [Serializable]
    public class PlayerData : object
    {
        [SerializeField]
        private string name;

        public string Name { get => name; set => name = value; }
    }
}
