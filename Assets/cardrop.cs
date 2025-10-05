using UnityEngine;
using Vivi;
public class cardrop : MonoBehaviour
{
    public soulcarstuff SCS;
    public NPCmovement NPCM;
    public void OnTriggerEnter(Collider other)
    {
        SCS = other.gameObject.GetComponent<soulcarstuff>();
        NPCM = other.gameObject.GetComponent<NPCmovement>();

        NPCM.stop();
        if (Input.GetKeyDown(KeyCode.B))
        {

            SCS.GetComponent<Rigidbody>().useGravity = true;
        }
    }

}

