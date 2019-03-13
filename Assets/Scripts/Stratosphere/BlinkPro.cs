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
        public float interval = 0.5f;
        private TextMeshPro mesh;
        private string text = "";

        private void Start()
        {
            mesh = GetComponent<TextMeshPro>();
            text = mesh.text;
            StartCoroutine("Blinker");
        }

        private IEnumerator Blinker()
        {
            while (gameObject.activeSelf)
            {
                mesh.text = text;
                yield return new WaitForSecondsRealtime(interval);
                mesh.text = "";
                yield return new WaitForSecondsRealtime(interval);
            }
        }

        private void OnDestroy()
        {
            mesh.text = text;
        }
    }
}
