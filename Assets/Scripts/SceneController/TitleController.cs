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

		}

		// Update is called once per frame
		void Update()
		{
			if (Input.GetButtonDown(Enum.GetName(typeof(ButtonName), ButtonName.Submit)))
			{
				if (UserDataExists)
					Loading.SetNextScene(Enum.GetName(typeof(SceneName), SceneName.Home));
				else
					Loading.SetNextScene(Enum.GetName(typeof(SceneName), SceneName.Home));  // Tutorialにしたい

				SceneManager.LoadScene(Enum.GetName(typeof(SceneName), SceneName.Loading));
			}
		}
	}
}
