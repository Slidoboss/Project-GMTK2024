using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostPickupSound : MonoBehaviour
{
    public AK.Wwise.Event PickupSound;
     // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            PickupSound.Post(gameObject);
        }
    }
}
