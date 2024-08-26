using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using Unity.VisualScripting;

public class PickupSystem : MonoBehaviour, IInteractable
{
    [Header("UI")]
    [SerializeField] private string prompt;

    [Header("Inventory")]
    [SerializeField] private InventoryManager inventoryManager;
    [SerializeField] private Item item;

    public string InteractionPromp => prompt;

    public void Interact(Interactors interactors)
    {
        inventoryManager.AddItem(item);
        gameObject.SetActive(false);
        AkSoundEngine.PostEvent("Player_Eat_Apple", gameObject);
    }
}

