using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntNestInteraction : MonoBehaviour, IInteractable
{
    [Header("UI")]
    [SerializeField] private string prompt;

    [Header("Funtionalities")]
    [SerializeField] private InventoryManager inventoryManager;
    [SerializeField] private Item _item;
    [Space]
    [SerializeField] private GameObject[] ants;
    public bool allAppleColected;

    public string InteractionPromp => prompt;

    public void Interact(Interactors interactors)
    {
        if (inventoryManager == null)
        {
            Debug.LogError("InventoryManager is not assigned.");
            return;
        }

        if (inventoryManager.inventorySlots == null)
        {
            Debug.LogError("InventorySlots array in InventoryManager is not assigned.");
            return;
        }

        if (_item == null)
        {
            Debug.LogError("Item (_item) is not assigned.");
            return;
        }

        for (int i = 0; i < inventoryManager.inventorySlots.Length; i++)
        {
            InventorySlot itemInSlot = inventoryManager.inventorySlots[i];
            InventoryItem inventoryItem = itemInSlot.GetComponentInChildren<InventoryItem>();

            if(inventoryItem.item == _item && inventoryItem.count == 6)
            {
                for(int o = 0; o < ants.Length; o++)
                {
                    ants[o].transform.position = this.gameObject.transform.position;
                }

                allAppleColected = true;
            }
        }
    }
}