using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactoryManager : MonoBehaviour
{
    public GoblinEnemyFactory goblinFactory; 
    public OrcEnemyFactory orcFactory;
    private IEnemyFactory currentFactory;
    private IEnemy enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            currentFactory = goblinFactory;
             enemy = currentFactory.CreateEnemy();
            enemy.Attack();
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            currentFactory = orcFactory;
             enemy = currentFactory.CreateEnemy();
            enemy.Attack();
        }
    }
}
