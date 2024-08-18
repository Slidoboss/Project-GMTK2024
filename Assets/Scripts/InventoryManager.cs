using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour, IInteractable
{
    private Inventory inventory =  new Inventory();

    public string InteractionPromp => "New item found";

    public void Interact(Interactors interactors)
    {

    }
}
