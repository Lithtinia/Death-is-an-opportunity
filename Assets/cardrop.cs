using UnityEngine;
using Vivi;
public class cardrop : MonoBehaviour
{
    public GameObject SCS;
    public NPCmovement NPCM;
    public void OnTriggerEnter(Collider other)
    {
        SCS = other.gameObject;
        NPCM = other.gameObject.GetComponent<NPCmovement>();

       
        if (Input.GetKeyDown(KeyCode.B))
        {
            hellchoice();
        }
    }

    public void hellchoice()
    {
        NPCM.moveon();
        SCS.GetComponent<Rigidbody>().useGravity = true;
            
        
    }
}

