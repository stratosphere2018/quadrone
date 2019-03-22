using UnityEngine;

namespace BeginIt.Quadrone {
    public abstract class CharacterController : MonoBehaviour {
        protected Battle battle;
        protected Battlefield battlefield { get => battle.battlefield; }
        protected Character character;

        public virtual void Init(Battle battle, Team team) {
            this.battle = battle;

            character = GetComponent<Character>();
            character.Init(battlefield, team);
        }

        protected void Move(Vector2 dist) {
            Vector2 taget = character.pos + dist;
            if (taget.x < 0
                || taget.x >= Battlefield.WIDTH
                || taget.y < 0
                || taget.y >= Battlefield.HEIGHT
                || !battlefield.GetArea(taget).IsTeam(character.team))
                return;

            character.pos += dist;
        }
    }
}