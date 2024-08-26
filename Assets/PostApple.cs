using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using Unity.VisualScripting.ReorderableList;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.Progress;
using static UnityEditor.Timeline.Actions.MenuPriority;

public class PostApple : MonoBehaviour
{
    public AK.Wwise.Event Event; 
 private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("applered01"))
        {
            Event.Post(gameObject);
        }
    }
}