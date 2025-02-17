using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public FactoryEnemy factoryEnemy;

    private void Start()
    {
        if (factoryEnemy == null)
        {
            return;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            Enemy orc = factoryEnemy.CreateEnemy(EnemyType.Orc);
            orc.Attack();
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            Enemy Golin = factoryEnemy.CreateEnemy(EnemyType.Golin);
            Golin.Attack();
        }
    }
}
