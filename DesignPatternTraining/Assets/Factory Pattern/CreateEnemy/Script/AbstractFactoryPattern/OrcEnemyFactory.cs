using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcEnemyFactory : MonoBehaviour, IEnemyFactory
{
    public GameObject orcPrefab;

    public IEnemy CreateEnemy()
    {
        return Instantiate(orcPrefab).GetComponent<OrcEneymy>();
    }
}
