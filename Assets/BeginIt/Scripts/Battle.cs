using UnityEngine;

namespace BeginIt.Quadrone {
    public class Battle : MonoBehaviour {
        Battlefield battlefield;

        void Awake() {
            battlefield = transform.Find("Battlefield").GetComponent<Battlefield>();

            battlefield.Init();
        }

        void Update() {
            
        }
    }
}
