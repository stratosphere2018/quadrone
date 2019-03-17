using UnityEngine;

namespace BeginIt.Quadrone {
    public sealed class PlayerController : CharacterController {
        public sealed override void Init(Battle battle, Team team) {
            base.Init(battle, team);

            character.pos = new Vector2(1, 1);
        }

        void Update() {
            if (InputButtonDown.upRepeat) {
                Move(new Vector2(0f, 1f));
            } else if (InputButtonDown.downRepeat) {
                Move(new Vector2(0f, -1f));
            } else if (InputButtonDown.leftRepeat) {
                Move(new Vector2(-1f, 0f));
            } else if (InputButtonDown.rightRepeat) {
                Move(new Vector2(1f, 0f));
            }
        }
    }
}
