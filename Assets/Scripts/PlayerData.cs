using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stratosphere.Quadrone
{
    [Serializable]
    public class PlayerData : object
    {
        /// <summary>
        /// プレイヤー名
        /// </summary>
        [SerializeField]
        private string name;

        /// <summary>
        /// プレイヤー名プロパティ
        /// </summary>
        public string Name { get => name; set => NameCheck(value); }

        /// <summary>
        /// プレイヤー名が有効であるかどうか
        /// </summary>
        /// <param name="value">入力された値</param>
        private void NameCheck(string value)
        {
            if (true)
            {
                name = value;
            }
        }
    }
}
