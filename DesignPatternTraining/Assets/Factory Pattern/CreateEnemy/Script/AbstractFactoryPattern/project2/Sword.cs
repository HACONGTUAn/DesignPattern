using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour, ICloseCombat
{
    public void CloseCombat()
    {
        Debug.Log("Chém bằng kiếm!");
    }
}
