using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OOP.Encapsulation.Basic
{
    public class Player
    {
    
        private float health = 100;
      

        public void SetHealth(float except)
        {
            if (health >= 0 && health <= 100)
            {
                health += except;
               
            }
        }
        public float GetHealth()
        {
            return health;
        }
    }

}
