using Stratosphere.Quadrone.Card;
using Stratosphere.Quadrone.Character;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Stratosphere.Quadrone
{
    [Serializable]
    public class PlayerData : object
    {
        public static PlayerData Data { get; set; }

        [SerializeField]
        private string _name;
        [SerializeField]
        private bool _gameStarted = false;
        [SerializeField]
        private CharName _unlockedCharacters;
        [SerializeField]
        private Dictionary<CardName, int> _cards;
        [SerializeField]
        private CardName[,] _folder;
        [SerializeField]
        private KeyConfig _keyCon;

        public PlayerData()
        {
            Name = "";
            UnlockedCharacters = CharName.None | CharName.TestCharacter;
            Cards = new Dictionary<CardName, int>();
            Folder = new CardName[5, 30];
            KeyCon = new KeyConfig();
        }

        public bool GameStarted { get => _gameStarted; set => _gameStarted = value; }
        public string Name { get => _name; set => NameCheck(value); }
        public CharName UnlockedCharacters { get => _unlockedCharacters; set => _unlockedCharacters = value; }
        public Dictionary<CardName, int> Cards { get => _cards; set => _cards = value; }
        public CardName[,] Folder { get => _folder; set => _folder = value; }
        public KeyConfig KeyCon { get => _keyCon; internal set => _keyCon = value; }

        private void NameCheck(string value)
        {
            if (true)
            {
                _name = value;
            }
        }

        public void LoadData(PlayerData savedata)
        {
            Name = savedata.Name;
            UnlockedCharacters = savedata.UnlockedCharacters;
            Cards = savedata.Cards;
            Folder = savedata.Folder;
        }
    }
}
