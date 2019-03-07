using System.Collections.Generic;
using UnityEngine;

namespace BeginIt.Quadrone {
    public class Battlefield : MonoBehaviour {
        public const int WIDTH = 6;
        public const int HEIGHT = 3;

        Dictionary<Vector2, Area> areas = new Dictionary<Vector2, Area>();

        public void Init() {
            Area areaPrefab = Resources.Load<Area>("Prefabs/Area");

            for (int x = 0; x < WIDTH; x++) {
                for (int y = 0; y < HEIGHT; y++) {
                    areas.Add(new Vector2(x, y),
                              ObjectEx.Instantiate<Area>(areaPrefab, transform, new Vector2((x - 2.5f) * 2.25f, y * -1.5f))
                                      .Creat((Team)(x / (WIDTH / 2))));
                }
            }
        }
    }
}