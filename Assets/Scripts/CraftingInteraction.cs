using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingInteraction : MonoBehaviour, IInteractable
{
    [Header("Interaction")]
    [SerializeField] private string promp;
    [SerializeField] private GameObject craftingUI;
    [SerializeField] private GameObject craftingManager;
    public string InteractionPromp => promp;

    private void Start()
    {
        craftingUI.SetActive(false);
        craftingManager.SetActive(false);
    }

    public void Interact(Interactors interactors)
    {
        craftingManager.SetActive(true);
        craftingUI.SetActive(true);
        AkSoundEngine.PostEvent("Player_Grab_WaterDroplets", gameObject);
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            craftingUI.SetActive(false);
            craftingManager.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
