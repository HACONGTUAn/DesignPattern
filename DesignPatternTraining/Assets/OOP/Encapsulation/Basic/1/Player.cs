using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OOP.Encapsulation.Basic
{
    public class Player
    {
        private float health = 100;

        public float Health
        {
            get { return health; }
            set { health = Mathf.Clamp(value, 0, 100); }
        }

        //public void SetHealth(float value)
        //{
        //    float newHealth = health + value;
        //    if (newHealth < 0)
        //        health = 0;
        //    else if (newHealth > 100)
        //        health = 100;
        //    else
        //        health = newHealth;
        //}
        //public float GetHealth()
        //{
        //    return health;
        //}
    }

}
