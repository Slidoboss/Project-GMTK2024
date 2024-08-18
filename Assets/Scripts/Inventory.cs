using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory 
{
    public List<CraftItem> bag;
    public Inventory()
    {
        bag = new List<CraftItem>();
    }
}
