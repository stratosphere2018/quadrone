using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stratosphere.Quadrone
{
    public delegate Vector2 GetAxis();
    public delegate bool GetButton();

    [RequireComponent(typeof(TextMesh))]
    public class KeyConfig : MonoBehaviour
    {
        public KeyConfig()
        {
            MenuSelect = InputExt.GetPoVAxis;
            Submit = InputExt.GetButton01Press;
            Cancel = InputExt.GetButton00Press;
            Move = InputExt.GetPoVAxis;
            Attack = InputExt.GetButton00Up;
            Charge = InputExt.GetButton00Down;
            UseCard = InputExt.GetButton01Press;
        }

        public GetAxis MenuSelect { get; set; }
        public GetButton Submit { get; set; }
        public GetButton Cancel { get; set; }
        public GetAxis Move { get; set; }
        public GetButton Attack { get; set; }
        public GetButton Charge { get; set; }
        public GetButton UseCard { get; set; }
        private TextMesh Mesh { get; set; }
        private int Select { get; set; } = 0;

        // Start is called before the first frame update
        void Start()
        {
            LoadConfig(PlayerData.Data.KeyCon);
            Mesh = GetComponent<TextMesh>();
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        private void LoadConfig(KeyConfig keyCon)
        {
            MenuSelect = keyCon.MenuSelect;
            Submit = keyCon.Submit;
            Cancel = keyCon.Cancel;
            Move = keyCon.Move;
            Attack = keyCon.Attack;
            Charge = keyCon.Charge;
            UseCard = keyCon.UseCard;
        }
    }
}
