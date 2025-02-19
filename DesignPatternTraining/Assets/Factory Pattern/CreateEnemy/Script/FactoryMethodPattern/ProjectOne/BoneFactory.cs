using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneFactory : EnemyFactory
{
    public GameObject boneEnemy;
    public override NewEnemy CreateEnemy()
    {
        return Instantiate(boneEnemy).GetComponent<BoneEnemy>();
    }
}
