using System;
using UnityEngine;
using Vivi;
public class carmovment : MonoBehaviour
{
    public NPCmovement NPCM;
    public void OnTriggerEnter(Collider other)
    { NPCM = other.gameObject.GetComponent<NPCmovement>();
        
      NPCM.stop();
    }

    public void start()
    {
        
    }
}
    
