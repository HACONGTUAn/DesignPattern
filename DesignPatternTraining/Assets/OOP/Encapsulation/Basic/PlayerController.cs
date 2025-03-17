using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace OOP.Encapsulation.Basic
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] Button addHealth;
        [SerializeField] Button exceptHealth;
        [SerializeField] Text TextHealth;
        private Player Player;

        private void Start()
        {
            Player = new Player();
            addHealth.onClick.AddListener(AddHealth);   
            exceptHealth.onClick.AddListener(ExceptHealth);
            ShowHealthPlayer();
        }
        private void AddHealth()
        {
            Player.SetHealth(10);
            ShowHealthPlayer();
        }
        private void ExceptHealth()
        {
            Player.SetHealth(-10);
            ShowHealthPlayer();
        }
        private void ShowHealthPlayer()
        {
            TextHealth.text = "Heath Player:" +  Player.GetHealth().ToString();
        }

    }
}