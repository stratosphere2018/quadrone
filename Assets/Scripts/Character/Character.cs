using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stratosphere.Quadrone
{
    public abstract partial class Character : MonoBehaviour
    {
        /// <summary>
        /// キャラクターの名前
        /// </summary>
        public string CharName { get; internal set; }

        /// <summary>
        /// キャラクターをアニメーションさせる
        /// </summary>
        /// <param name="type">アニメーションの種類</param>
        public abstract void Animate(CharAnimType type);
    }
}
