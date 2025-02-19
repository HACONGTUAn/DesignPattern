using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGameManager : MonoBehaviour
{
    public EnemyFactory orcFactory;
    public EnemyFactory goblinFactory;
    public EnemyFactory boneFactory;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            CreateEnemy(orcFactory);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            CreateEnemy(goblinFactory);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            CreateEnemy(boneFactory);
        }
    }
    void CreateEnemy(EnemyFactory factory)
    {
        NewEnemy enemy = factory.CreateEnemy();
        enemy.Attack();
    }
}
