using System;
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
		public StrSceneNamePair[] scenes;

		/// <summary>
		/// テキストメッシュ
		/// </summary>
		private TextMesh Mesh { get; set; }
		/// <summary>
		/// 選択中の項目格納用
		/// </summary>
		public int Select { get; private set; }

		// Start is called before the first frame update
		void Start()
		{
			Mesh = GetComponent<TextMesh>();    // TextMeshコンポーネントを取得
			Select = 0;                         // 選択項目をリセット

		}

		// Update is called once per frame
		void Update()
		{
			if (Input.GetButtonDown(Enum.GetName(typeof(ButtonName), ButtonName.Vertical)))
			{
				float inputY = Input.GetAxis(Enum.GetName(typeof(ButtonName), ButtonName.Vertical));

				// 入力情報取得/選択項目変更
				if (inputY > 0)
				{
					Select--;
				}
				else if (inputY < 0)
				{
					Select++;
				}
				Select = (int)Mathf.Clamp(Select, 0f, scenes.Length - 1);

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
						Mesh.text += "   ";
					}
					Mesh.text += scenes[i].key + "\n";
				}
			}
		}
	}
}
