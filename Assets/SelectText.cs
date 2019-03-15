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
        /// 表示するテキスト
        /// </summary>
        public string[] textToShow;
        /// <summary>
        /// textToShowに対応するシーンの名前
        /// </summary>
        public string[] sceneName;

        /// <summary>
        /// テキストメッシュ
        /// </summary>
        private TextMesh Mesh { get; set; }
        /// <summary>
        /// 選択中の項目格納用
        /// </summary>
        private int Select { get; set; }
        /// <summary>
        /// エラー可否
        /// </summary>
        private bool Error { get; set; } = false;

        // Start is called before the first frame update
        void Start()
        {
            Mesh = GetComponent<TextMesh>();    // TextMeshコンポーネントを取得
            Select = 0;                         // 選択項目をリセット

            // シーンの長さが一致していなければエラーを吐く
            if (sceneName.Length != textToShow.Length)
            {
                Debug.LogError("シーン数と項目数が一致してない");
                Error = true;
            }

        }

        // Update is called once per frame
        void Update()
        {
            // 起動時にエラーが発生していたらUIを表示しない
            if (Error) return;

            // 入力情報取得/選択項目変更
            if (Input.GetAxis("Vertical") > 0)
            {
                Select++;
            }
            else if (Input.GetAxis("Vertical") < 0)
            {
                Select--;
            }
            Mathf.Clamp(Select, 0, 3);

            // テキストレンダー
            Mesh.text = "";
            for (int i = 0; i < textToShow.Length; i++)
            {
                if (i == Select)
                {
                    Mesh.text += "ﾆｱ ";
                }
                else
                {
                    Mesh.text += "   ";
                }
                Mesh.text += textToShow[i] + "\n";
            }
        }
    }
}
