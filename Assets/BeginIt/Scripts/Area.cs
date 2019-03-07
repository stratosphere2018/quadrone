﻿using UnityEngine;

namespace BeginIt.Quadrone {
    public class Area : MonoBehaviour {
        SpriteRenderer image;

        Team team;

        void Awake() {
            image = transform.Find("Image").GetComponent<SpriteRenderer>();
        }

        public Area Creat(Team team) {
            SetTeam(team);

            return this;
        }

        void SetTeam(Team team) {
            this.team = team;
            if (team == Team.Left) {
                image.color = Color.red;
            } else if (team == Team.Right) {
                image.color = Color.blue;
            }
        }
    }
}
