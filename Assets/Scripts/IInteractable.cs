using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    public string InteractionPromp {  get; }
    public void Interact(Interactors interactors,CraftItem item);
}
