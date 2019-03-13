using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Stratosphere.Quadrone
{
    public class TitleController : SceneController
    {

        // Update is called once per frame
        void Update()
        {
            if (Input.GetButtonDown("Submit"))
            {
                Loading.SetNextScene("Home");
                SceneManager.LoadScene("Loading");
            }
        }
    }
}
