using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon
{
    private string nameWeapon;
    private float damege = 0;
    private float fireRate = 0.1f;
    public string NameWeapon { get => nameWeapon; }
    public float Damage { get => damege; private set  { if (value > 0) damege = value; else Debug.LogError("damege must > 0"); } }
    public float FireRate { get => fireRate; private set { if (value > 0) fireRate = value; else Debug.LogError("fireRate must > 0"); } }
    public Weapon(string _nameWeapon, float _damege, float _fireRate)
    {
        this.nameWeapon = _nameWeapon;
        //if (_damege > -1) this.damage = _damege;
        //if (_fireRate > 0) this.fireRate = _fireRate;
        // khong nen viet dieu kien o day vi sao ?
        // khi kiem tra dieu kien o day thi chi minh trong Constructor nay duoc kiem tra dieu kien 
        // khi damege duoc gan du lieu o dau do trong noi bo cua class nay hoac duoc gan o ngoai class dieu kien khong he duoc kiem tra
        //=> gay ra loi 
        // hay kiem tra dieu kien trong getter , setter

        Damage = _damege;
        FireRate = _fireRate;
    }
}
