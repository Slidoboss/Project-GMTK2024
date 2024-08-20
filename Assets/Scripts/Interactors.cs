using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interactors : MonoBehaviour
{
    public Transform interactionPoint;
    public float interactionPointRadius;
    [SerializeField] private LayerMask interactionMask;
    [SerializeField] private int collidersFound;
    [SerializeField] private InteractionPrompt interactionPrompt;

    private readonly Collider[] colliders = new Collider[3];
    private IInteractable _interactable;

    private void Update()
    {
        collidersFound = Physics.OverlapSphereNonAlloc(interactionPoint.position, interactionPointRadius, colliders, interactionMask);

        if(collidersFound > 0)
        {
            _interactable = colliders[0].GetComponent<IInteractable>();

            if(_interactable != null)
            {
                if(!interactionPrompt.IsDisplayed)
                {
                    interactionPrompt.Setup(_interactable.InteractionPromp);
                }

                if(Keyboard.current.eKey.wasPressedThisFrame)
                {
                    _interactable.Interact(this);
                }
            } 
        }
        else
        {
            if (_interactable != null)
            {
                _interactable = null;
            }

            if (interactionPrompt.IsDisplayed)
            {
                interactionPrompt.Close();
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(interactionPoint.position, interactionPointRadius);
    }
}
