using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField] private List<Text> inventoryText = new List<Text>();
    [SerializeField] int MaxPotion = 10;
    [SerializeField] int MaxSword = 10;
    [SerializeField] int MaxShield = 10;
    [SerializeField] int MaxGold = 10;

    float currentPotion = 0;
    float currentSword = 0;
    float currentShield = 0;
    float currentGold = 0;
    public void AddItem(Item item)
    {
        switch (item.ID)
        {
            case 0:
                if (currentPotion + item.Weight < MaxPotion)
                {
                    currentPotion += item.Weight;
                }
                else
                {
                    currentPotion = MaxPotion;
                }
                Show(item, currentPotion);
                break;
            case 1:
                if (currentSword + item.Weight < MaxSword)
                {
                    currentSword += item.Weight;
                }
                else
                {
                    currentSword = MaxSword;
                }
                Show(item, currentSword);
                break;
            case 2:
                if (currentShield + item.Weight < MaxShield)
                {
                    currentShield += item.Weight;
                    Show(item, currentShield);
                }
                else
                {
                    currentShield = MaxShield;
                }
                Show(item, currentShield);
                break;
            case 3:
                if (currentGold + item.Weight < MaxGold)
                {
                    currentGold += item.Weight;
                }
                else
                {
                    currentGold = MaxGold;
                }
                Show(item, currentGold);
                break;
        }
    }
    public void Show(Item item, float currentWeight)
    {
        inventoryText[item.ID].text = item.NameItem + " :" + currentWeight;
    }

   /* cau hoi dat ra la viec mo rong them , khi them doi tuong moi hay them item vao thi ban phai sua doi
    * VD them loai moi la Bow 
    * phai viet them MaxBow
    * them CurrentBow
    * them Case trong AddItem()
    * them text moi trong InventoryText
    * Giai quyet dieu nay bang cach la su dung Dictionary + ScriptableObject /enum + Cau truc du lieu dong
    * gom nhom nhung thuc giong nhau lai 
    */
}
