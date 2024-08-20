using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class TreeGrowing : MonoBehaviour, IInteractable
{
    [Header("UI")]
    [SerializeField] private string prompt;

    [Header("Visuals")]
    [SerializeField] private GameObject stage1;
    [SerializeField] private GameObject stage2;
    [SerializeField] private GameObject stage3;
    [SerializeField] private GameObject stage4;
    [SerializeField] private int stage = 1;
    [Space]
    [SerializeField] private GameObject noChemicalUI;

    [Header("Funtionalities")]
    [SerializeField] private InventoryManager inventoryManager;

    public string InteractionPromp => prompt;

    public async void Interact(Interactors interactors)
    {
        if (inventoryManager.GetSelectedItem(true).type == Item.ItemType.ChemicalResult)
        {
            stage++;
            TreeStageCheck();
        }
    }

    private void TreeStageCheck()
    {
        if(stage == 2)
        {
            stage1.SetActive(false);
            stage2.SetActive(true);
        }

        if(stage == 3)
        {
            stage2.SetActive(false);
            stage3.SetActive(true);
        }

        if(stage == 4)
        {
            stage3.SetActive(false);
            stage4.SetActive(true);
        }
    }
}
