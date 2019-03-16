using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stratosphere.Quadrone
{
    public abstract class Card : MonoBehaviour
    {
        /// <summary>
        /// カード名
        /// </summary>
        public string SkillName { get; internal set; }
        /// <summary>
        /// 説明に表示する威力
        /// </summary>
        public int Strength { get; internal set; }
        /// <summary>
        /// 説明欄の説明
        /// </summary>
        public string Description { get; internal set; }

        /// <summary>
        /// 使用した際の効果
        /// </summary>
        /// <param name="executioner">使用するプレイヤー</param>
        /// <param name="opponent">使用されるプレイヤー</param>
        internal abstract void Effect(Character executioner, Character opponent);

        /// <summary>
        /// 実際に使用する際の関数
        /// </summary>
        /// <param name="executioner">使用するプレイヤー</param>
        /// <param name="opponent">使用されるプレイヤー</param>
        public void Use(Character executioner, Character opponent)
        {
            Effect(executioner, opponent);
        }
    }
}
