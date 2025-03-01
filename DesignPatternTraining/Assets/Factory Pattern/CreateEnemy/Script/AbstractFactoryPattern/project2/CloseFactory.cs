using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseFactory : MonoBehaviour , IWeaponFactory
{
    public GameObject sword;
    public GameObject axe;
    public ICloseCombat CreateCloseCombat()
    {
        return Instantiate(sword).GetComponent<ICloseCombat>();
    }

    public ILongRange CreateLongRange()
    {
        return null;
    }
}
