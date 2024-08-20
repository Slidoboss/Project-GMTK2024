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
    [SerializeField] private PlayerShirnk playerShirnk;

    [Header("Funtionalities")]
    [SerializeField] private InventoryManager inventoryManager;

    public string InteractionPromp => prompt;

    private void Start()
    {
        //Testing :D
        TreeStageCheck();
    }

    public void Interact(Interactors interactors)
    {
        Debug.Log("Interaction");

        if (inventoryManager.GetSelectedItem(true).type == Item.ItemType.ChemicalResult && stage != 3 && !playerShirnk.isShrunk)
        {
            stage++;
            TreeStageCheck();
        } else if(inventoryManager.GetSelectedItem(true).type == Item.ItemType.ChemicalResult && stage == 3 && !playerShirnk.isShrunk) {
            playerShirnk.Shrink();
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
