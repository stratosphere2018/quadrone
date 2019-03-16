using System;
using System.Collections.Generic;

namespace Stratosphere.Quadrone
{
	/// <summary>
	/// 文字列とシーン名列挙体のペアクラス
	/// テンプレートだとインスペクタ―に表示できないため、
	/// ほとんど空のクラス
	/// </summary>
	[Serializable]
	public class StrSceneNamePair : Pair<string, SceneName>
	{
	}
}
