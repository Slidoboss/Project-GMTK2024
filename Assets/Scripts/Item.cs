using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Item")]
public class Item : ScriptableObject
{
    [Header("Gameplay")]
    public ItemType type;
    public Action actionType;
    public Vector2Int range = new Vector2Int(5, 4);
    public string name;

    [Header("UI")]
    public bool stackable = true;
    public Sprite image;

    public enum ItemType
    {
        Chemical,
        ChemicalResult
    }

    public enum Action
    {
        None,
        UseChemical
    }
}
