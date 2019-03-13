using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stratosphere
{
    /// <summary>
    /// TextMeshの文字を一定の間隔で点滅させる
    /// </summary>
    [RequireComponent(typeof(TextMesh))]
    public class Blink : MonoBehaviour
    {
        public float interval = 0.5f;
        private TextMesh mesh;
        private string text = "";

        private void Start()
        {
            mesh = GetComponent<TextMesh>();
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
