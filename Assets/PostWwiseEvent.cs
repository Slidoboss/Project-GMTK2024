using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ak;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine.Events;
using static UnityEngine.Rendering.DebugUI;


public class PostWwiseEvent : MonoBehaviour
{ 
    public class AkTriggerDisable : AkTriggerBase
    {
        public void OnDisable()
        {
            AkSoundEngine.PostEvent("Player_Eat_Apple", gameObject);
        }
    }
}

 



