using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Stratosphere.Quadrone
{
    public class Loading : MonoBehaviour
    {
        public static string NextScene { get; private set; }

        // Start is called before the first frame update
        void Start()
        {
            SceneManager.LoadSceneAsync(NextScene);
        }

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(0f, 0f, 30f * Time.deltaTime);
        }

        public static void SetNextScene(string sceneName)
        {
            NextScene = sceneName;
        }
    }
}
