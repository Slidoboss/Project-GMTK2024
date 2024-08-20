using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CraftingManager : MonoBehaviour
{
    private Item currentItem;
    [Header("Items")]
    [SerializeField] private Image customCursor;
    [Space]
    [SerializeField] private CraftingSlot[] craftingSlots;

    [Header("Recipes")]
    [SerializeField] private List<Item> itemList;
    [SerializeField] private string[] recipes;
    [Space]
    [SerializeField] private Item[] recipeResults;
    [SerializeField] private CraftingSlot resultSlot;

    [Header("Inventory Logic")]
    [SerializeField] private InventoryManager inventoryManager;
    [SerializeField] private GameObject craftingUI;
    [HideInInspector] public bool hasChemical;


    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (currentItem != null)
            {
                if (customCursor != null)
                {
                    customCursor.gameObject.SetActive(false);
                }

                // Find the nearest slot
                CraftingSlot nearestSlot = null;
                float shortestDistance = float.MaxValue;

                foreach (CraftingSlot slot in craftingSlots)
                {
                    if (slot == null) continue; // Skip null slots

                    // Calculate distance between mouse position and slot position
                    float dist = Vector2.Distance(Input.mousePosition, slot.transform.position);

                    if (dist < shortestDistance)
                    {
                        shortestDistance = dist;
                        nearestSlot = slot;
                        nearestSlot.gameObject.SetActive(true);
                    }
                }

                if (nearestSlot != null)
                {
                    // Ensure the slot has an Image component
                    Image slotImage = nearestSlot.GetComponent<Image>();
                    nearestSlot.gameObject.SetActive(true);
                    if (slotImage != null)
                    {
                        slotImage.sprite = currentItem.image;
                        nearestSlot.item = currentItem;
                    }
                    else
                    {
                        Debug.LogError("Image component missing on CraftingSlot.");
                    }
                }
                else
                {
                    Debug.LogWarning("No valid CraftingSlot found.");
                }

                itemList[nearestSlot.index] = currentItem;
                // Reset currentItem after placement
                currentItem = null;
                CheckForCreatedRecipe();
            }
        }
    }

    public void OnMouseDownItem(Item item)
    {
        if (item == null) return; // Check if item is null

        if (currentItem == null)
        {
            currentItem = item;
            if (customCursor != null)
            {
                customCursor.gameObject.SetActive(true);
                customCursor.sprite = currentItem.image;
            }
        }
    }

    private void CheckForCreatedRecipe()
    {
        resultSlot.gameObject.SetActive(false);
        resultSlot.item = null;

        string currentRecipeString = "";
        foreach(Item item in itemList)
        {
            if(item != null)
            {
                currentRecipeString += item.name;
            } else
            {
                currentRecipeString = "null";
            }
        }

        for(int i = 0; i < recipes.Length; i++)
        {
            if (recipes[i] == currentRecipeString)
            {
                resultSlot.gameObject.SetActive(true);
                resultSlot.GetComponent<Image>().sprite = recipeResults[i].image;
                resultSlot.item = recipeResults[i];
            }
        }
    }

    public void AddItemToInventory()
    {
        if (inventoryManager == null)
        {
            Debug.LogError("inventoryManager is null.");
            return;
        }

        // Check if resultSlot is assigned
        if (resultSlot == null)
        {
            Debug.LogError("resultSlot is null.");
            return;
        }

        // Check if resultSlot.item is assigned
        if (resultSlot.item == null)
        {
            Debug.LogError("resultSlot.item is null.");
            return;
        }

        inventoryManager.AddItem(resultSlot.item);
        craftingUI.gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        hasChemical = true;
        gameObject.SetActive(false);
    }

    public void OnClickSlot(CraftingSlot slot)
    {
        slot.item = null;
        itemList[slot.index] = null;
        slot.gameObject.SetActive(false);
        CheckForCreatedRecipe();
    }

    private void OnEnable()
    {
        Cursor.lockState = CursorLockMode.None;
    }
}
