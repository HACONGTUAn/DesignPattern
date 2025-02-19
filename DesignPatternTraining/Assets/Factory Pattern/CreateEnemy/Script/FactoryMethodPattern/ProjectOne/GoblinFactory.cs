using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinFactory : EnemyFactory
{
    public GameObject goblin;
    public override NewEnemy CreateEnemy()
    {
        return Instantiate(goblin).GetComponent<NewGoblin>();
    }
}
