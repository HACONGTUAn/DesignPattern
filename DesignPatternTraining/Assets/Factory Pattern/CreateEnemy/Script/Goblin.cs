using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Enemy
{
    public override void Attack()
    {
        Rigidbody rg = GetComponent<Rigidbody>();
        float positionX = Random.Range(-1f, 1f);
        float positionz = Random.Range(0f, -1f);
        rg.AddForce(new Vector3(positionX, 1.05f, positionz));
    }

   
}
