using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Stratosphere.Quadrone
{
    /// <summary>
    /// 要る？
    /// </summary>
    public class TitleController : SceneController
    {
        public bool UserDataExists { get; private set; }

        private void Start()
        {
            if (PlayerPrefs.HasKey("Savedata"))
            {
                PlayerData.Data = JsonUtility.FromJson<PlayerData>(PlayerPrefs.GetString("Savedata"));
            }
            else
            {
                PlayerData.Data = new PlayerData();
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetButtonDown(Enum.GetName(typeof(ButtonName), ButtonName.Submit)))
            {
                if (PlayerData.Data.GameStarted)
                {
                    Loading.SetNextScene(SceneName.Home.ToString());
                }
                else
                {
                    PlayerData.Data.GameStarted = true;
                    PlayerData.Data.Name = "testName";
                    PlayerPrefs.SetString("Savedata", JsonUtility.ToJson(PlayerData.Data));
                    PlayerPrefs.Save();
                    Loading.SetNextScene(SceneName.Home.ToString());  // Tutorialにしたい
                }

                SceneManager.LoadScene(SceneName.Loading.ToString());
            }
        }
    }
}
