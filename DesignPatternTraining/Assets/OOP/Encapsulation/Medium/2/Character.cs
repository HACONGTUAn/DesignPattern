using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    [SerializeField] Text textHealth;
    [SerializeField] Text textMana;
    [SerializeField] Text textAttack;
    [SerializeField] Text textDefense;

    private CharacterStat Health;
    private CharacterStat Mana;
    private CharacterStat Attack;
    private CharacterStat Defense;
    void Start()
    {
        Health = new CharacterStat(100, textHealth);
        Mana = new CharacterStat(100, textMana);
        Attack = new CharacterStat(50, textAttack);
        Defense = new CharacterStat(10, textDefense);
    }


   
}
