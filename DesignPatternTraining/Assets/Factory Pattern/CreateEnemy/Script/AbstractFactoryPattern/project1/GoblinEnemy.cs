using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinEnemy :MonoBehaviour, IEnemy
{
    public void Attack()
    {
        Debug.Log("GoblinEnemy Attack");
    }

   
}
