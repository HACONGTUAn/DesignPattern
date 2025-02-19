using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcFactory : EnemyFactory
{
    public GameObject orc;
    public override NewEnemy CreateEnemy()
    {
        return Instantiate(orc).GetComponent<NewOrc>();
    }

    
}
