using UnityEngine;

namespace BeginIt.Quadrone {
    public class Battle : MonoBehaviour {
        public Battlefield battlefield { get; private set; }
        PlayerController player;

        void Awake() {
            battlefield = transform.Find("Battlefield").GetComponent<Battlefield>();
            player = transform.Find("Player").GetComponent<PlayerController>();

            battlefield.Init();
            player.Init(this, Team.Left);
        }

        void Update() {
            
        }
    }
}
