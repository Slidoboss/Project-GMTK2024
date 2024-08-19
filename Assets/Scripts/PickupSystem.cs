using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class PickupSystem : MonoBehaviour, IInteractable
{
    [Header("UI")]
    [SerializeField] private string prompt;
    [Space]
    [SerializeField] private InteractionPrompt interactionPrompt;

    [Header("Inventory")]
    [SerializeField] private InventoryManager inventoryManager;
    [SerializeField] private Item item;

    public string InteractionPromp => prompt;

    public void Interact(Interactors interactors)
    {
        inventoryManager.AddItem(item);
        interactionPrompt.Close();
        gameObject.SetActive(false);
    }
}
