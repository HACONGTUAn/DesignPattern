using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinEnemyFactory : MonoBehaviour,IEnemyFactory
{
    public GameObject goblinPrefab;
    public IEnemy CreateEnemy()
    {
        return Instantiate(goblinPrefab).GetComponent<GoblinEnemy>();
    }

  
}
