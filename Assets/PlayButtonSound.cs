using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButtonSound : MonoBehaviour
{
    public void Updade()
    {
        if (Input.GetKeyUp(KeyCode.E))
            Debug.Log("E key was pressed.");
        AkSoundEngine.PostEvent("Player_Eat_Apple", gameObject);
    }
}

