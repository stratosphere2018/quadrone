using UnityEngine;

namespace Stratosphere.Quadrone
{
	public class BattleField : MonoBehaviour
	{
		public GameObject panel;

		private GameObject[,] Panels { get; set; }

		private void Awake()
		{
			Panels = new GameObject[6, 3];
			for (int i = 0; i < 6; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					Panels[i, j] = Instantiate(panel, transform);
					Vector3 tmp = new Vector3(-5f + i * 2f, -j * 1.32f, 0f);
					Panels[i, j].transform.position = tmp;
				}
			}
		}
	}
}
