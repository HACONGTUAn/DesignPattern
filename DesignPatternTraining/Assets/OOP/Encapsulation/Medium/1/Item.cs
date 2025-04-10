using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Item 
{
    private int id;
    private string nameItem;
    private float quantity;
    private float weight;

    public int ID { get => id; set => id = value; }
    public string NameItem { get => nameItem; set => nameItem = value; }
    public float Quantity { get => quantity; set => quantity = value; }
    public float Weight { get => Weight; set => Weight = value; }

    public Item(int _id, string _nameItem, float _quantity, float _weight)
    {
        ID = _id;
        NameItem = _nameItem;       
        Quantity = _quantity;
        Weight = _weight;
    }
}
