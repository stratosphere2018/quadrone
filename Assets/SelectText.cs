using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Stratosphere.Quadrone
{
    [RequireComponent(typeof(TextMesh))]
    public class SelectText : MonoBehaviour
    {
        public string[] SceneName;
        public string[] ShowText;
        private TextMesh Mesh;
        private int Select;
        bool Error = false;

        // Start is called before the first frame update
        void Start()
        {
            Mesh = GetComponent<TextMesh>();
            Select = 0;

            if (SceneName.Length != ShowText.Length)
            {
                Debug.LogError("シーン数と項目数が一致してない");
                Error = true;
            }

        }

        // Update is called once per frame
        void Update()
        {
            if (Error) return;

            if (Input.GetAxis("Vertical") > 0)
            {
                Select++;
            }
            else if (Input.GetAxis("Vertical") < 0)
            {
                Select--;
            }
            Mathf.Clamp(Select, 0, 3);

            Mesh.text = "";
            for (int i = 0; i < ShowText.Length; i++)
            {
                if (i == Select)
                {
                    Mesh.text += "ﾆｱ ";
                }
                else
                {
                    Mesh.text += "   ";
                }
                Mesh.text += ShowText[i] + "\n";
            }


        }
    }
}
