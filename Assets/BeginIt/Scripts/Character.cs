using UnityEngine;

namespace BeginIt.Quadrone {
    public abstract class Character : MonoBehaviour {
        public Team team { get; private set; }

        protected Battlefield battlefield;
        protected Vector2 posValue;

        public Vector2 pos {
            get => posValue;
            set {
                posValue = value;
                transform.SetPositioin(battlefield.GetArea(pos).GetPosition());
            }
        }

        public void Init(Battlefield battlefield, Team team) {
            this.battlefield = battlefield;
            this.team = team;
        }
    }
}