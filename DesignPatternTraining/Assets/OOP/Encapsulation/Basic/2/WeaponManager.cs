using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] Button nextBtn;
    [SerializeField] Button backBtn;
    [SerializeField] UnityEngine.UI.Text textUI;
    private List<Weapon> weapons = new List<Weapon>();
    private int currenIndex = 0;
    private void Awake()
    {
        nextBtn.onClick.AddListener(NextWeapons);
        backBtn.onClick.AddListener(BacktWeapons);
    }
    private void Start()
    {
        Weapon Pistol = new Weapon("Pistol", 10, 0.5f);
        Weapon Rifle = new Weapon("Rifle", 11, 5f);
        Weapon Shotgun = new Weapon("Shotgun", 12, 20f);

        weapons.Add(Pistol);
        weapons.Add(Rifle);      
        weapons.Add(Shotgun);

        ShowTextUi(weapons[currenIndex].NameWeapon + " " + weapons[currenIndex].Damage + " " + weapons[currenIndex].FireRate);
    }
    void NextWeapons()
    {
        currenIndex++;
        if(currenIndex >= weapons.Count)  currenIndex = weapons.Count - 1;
        ShowTextUi(weapons[currenIndex].NameWeapon + " " + weapons[currenIndex].Damage + " " + weapons[currenIndex].FireRate);
    }
    void BacktWeapons()
    {
        currenIndex--;
        if (currenIndex <= 0) currenIndex = 0;
        ShowTextUi(weapons[currenIndex].NameWeapon + " " + weapons[currenIndex].Damage + " " + weapons[currenIndex].FireRate);
    }
   
    void ShowTextUi(string text)
    {
        textUI.text = text;
    }
}
