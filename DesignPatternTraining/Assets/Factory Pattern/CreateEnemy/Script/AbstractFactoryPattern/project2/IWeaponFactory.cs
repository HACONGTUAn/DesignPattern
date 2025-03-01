using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeaponFactory
{
     ICloseCombat CreateCloseCombat();
     ILongRange CreateLongRange();
}
