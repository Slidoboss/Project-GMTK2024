using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public InventorySlot[] inventorySlots;
    [SerializeField] private GameObject inventoryItemPrefab;

    public void AddItem(Item item)
    {
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            InventorySlot slot = inventorySlots[i];
            InventoryItem itemInSlot = slot.GetComponentInChildren<InventoryItem>();
            if(itemInSlot == null)
            {
                SpawnNewItem(item, slot);
                return;
            }
        }
    }

    private void SpawnNewItem(Item item, InventorySlot slot)
    {
        GameObject newItemGameobject = Instantiate(inventoryItemPrefab, slot.transform);
        InventoryItem inventoryItem = newItemGameobject.GetComponent<InventoryItem>();
        inventoryItem.InitialiseItem(item);
    }
}
