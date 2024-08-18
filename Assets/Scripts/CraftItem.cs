using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftItem : MonoBehaviour, IInteractable
{
   public string itemName;
   public Sprite itemSprite;
   public int _itemQuantity;
   public List<string> _tags;

    public string InteractionPromp => $"CraftItem {itemName} picked up";

    public void Interact(Interactors interactors)
    {
        throw new NotImplementedException();
    }
}
