using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractionPrompt : MonoBehaviour
{
    [SerializeField] private GameObject interactionUI;
    [SerializeField] protected TextMeshProUGUI promptText;

    private void Start()
    {
        interactionUI.SetActive(false);
    }

    public bool IsDisplayed = false;
    public void Setup(string _promptText)
    {
        promptText.text = "E - " + _promptText;
        interactionUI.SetActive(true);
        IsDisplayed = true;
    }

    public void Close()
    {
        interactionUI.SetActive(false);
        IsDisplayed = false;
    }
}
