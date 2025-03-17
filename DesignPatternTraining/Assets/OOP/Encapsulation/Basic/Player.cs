using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OOP.Encapsulation.Basic
{
    public class Player
    {
        private float health = 100;
        private float currentHealth = 0;


        public void SetHealth(float except)
        {
            if (currentHealth >= 0 && currentHealth <= 100)
            {
                health += except;
                currentHealth = health;
            }
        }
        public float GetHealth()
        {
            return health;
        }
    }

}
