using System.Collections;
using TMPro;
using UnityEngine;

namespace Stratosphere
{
    /// <summary>
    /// TextMeshProの文字を一定の間隔で点滅させる
    /// </summary>
    [RequireComponent(typeof(TextMeshPro))]
    public class BlinkPro : MonoBehaviour
    {
        /// <summary>
        /// 点滅感覚(デフォルト:0.5秒)
        /// </summary>
        public float interval = 0.5f;

        /// <summary>
        /// テキストメッシュPro
        /// </summary>
        private TextMeshPro Mesh { get; set; }
        /// <summary>
        /// テキスト格納用
        /// </summary>
        private string Text { get; set; } = "";

        private void Start()
        {
            Mesh = GetComponent<TextMeshPro>(); // TextMeshProコンポーネントを取得
            Text = Mesh.text;                   // テキストの内容を取得/保持
            StartCoroutine("Blinker");          // コルーチン開始
        }

        /// <summary>
        /// 点滅コルーチン
        /// </summary>
        /// <returns></returns>
        private IEnumerator Blinker()
        {
            while (gameObject.activeSelf)
            {
                Mesh.text = Text;
                yield return new WaitForSecondsRealtime(interval);
                Mesh.text = "";
                yield return new WaitForSecondsRealtime(interval);
            }
        }

        /// <summary>
        /// 念のためテキスト情報をリセット
        /// </summary>
        private void OnDestroy()
        {
            Mesh.text = Text;
        }
    }
}
