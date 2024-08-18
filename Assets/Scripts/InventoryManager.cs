using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour, IInteractable
{
    private Inventory inventory =  new Inventory();

    public string InteractionPromp => "New item found";

    public void AddItem(CraftItem item)
    {
        if (item != null)
        {
            inventory.bag.Add(item);
            Debug.Log($"Item added. Current item count: {inventory.bag.Count}");
        }
        else
        {
            Debug.LogWarning("Attempted to add a null item to the inventory.");
        }
    }
    public List<CraftItem> GetItems()
    {
        return new List<CraftItem>(inventory.bag);
    }

    public void Interact(Interactors interactors)
    {
        Debug.Log("Interaction");
    }
}
