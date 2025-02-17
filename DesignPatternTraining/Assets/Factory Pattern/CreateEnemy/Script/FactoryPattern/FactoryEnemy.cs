using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyType
{
    Orc,
    Golin
}
public class FactoryEnemy : MonoBehaviour
{
    public GameObject orc;
    public GameObject Goblin;
    public Enemy CreateEnemy(EnemyType typeEnemy)
    {
        switch (typeEnemy)
        {
            case EnemyType.Orc:
                return Instantiate(orc).GetComponent<Orc>();
                break;
            case EnemyType.Golin:
                return Instantiate(Goblin).GetComponent<Goblin>();
                break;

            default:
                return null;
        }
    }
}
