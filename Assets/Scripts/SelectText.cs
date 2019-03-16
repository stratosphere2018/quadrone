using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Stratosphere.Quadrone
{
    /// <summary>
    /// 項目選択UI
    /// </summary>
    [RequireComponent(typeof(TextMesh))]
    public class SelectText : MonoBehaviour
    {
        /// <summary>
        /// 文字列ペア
        /// key:表示する文字列
        /// value:シーン名
        /// </summary>
        public StringPair[] scenes;

        /// <summary>
        /// テキストメッシュ
        /// </summary>
        private TextMesh Mesh { get; set; }
        /// <summary>
        /// 選択中の項目格納用
        /// </summary>
        private int Select { get; set; }

        // Start is called before the first frame update
        void Start()
        {
            Mesh = GetComponent<TextMesh>();    // TextMeshコンポーネントを取得
            Select = 0;                         // 選択項目をリセット
        }

        // Update is called once per frame
        void Update()
        {
            // 入力情報取得/選択項目変更
            if (Input.GetAxis("Vertical") > 0)
            {
                Select--;
            }
            else if (Input.GetAxis("Vertical") < 0)
            {
                Select++;
            }
            Select = Mathf.Clamp(Select, 0, scenes.Length-1);

            // テキストレンダー
            Mesh.text = "";
            for (int i = 0; i < scenes.Length; i++)
            {
                if (i == Select)
                {
                    Mesh.text += "ﾆｱ ";
                }
                else
                {
                    Mesh.text += "     ";
                }
                Mesh.text += scenes[i].key + "\n";
            }
        }
    }
}
