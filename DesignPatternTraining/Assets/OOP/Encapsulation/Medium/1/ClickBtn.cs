using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickBtn : MonoBehaviour
{
    [SerializeField] private Inventory inventory;
    [SerializeField] private int id;
    [SerializeField] private string nameItem;
    [SerializeField] private float quantity;
    [SerializeField] private float weight;
    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(GetItem);
    }
    void GetItem()
    {
        inventory.AddItem(new Item(id, nameItem, quantity, weight));
    }
}
