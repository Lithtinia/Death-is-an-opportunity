using UnityEngine;
using Vivi;

public class correctbutton : MonoBehaviour
{
    public NPCmovement NPC;
    public carmovment car;
    public GameObject stopper;
    public void OnTriggerEnter(Collider other)
    {
        NPC =other.gameObject.GetComponent<NPCmovement>();
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (other.gameObject.CompareTag("Player"))
            {
                //car.enabled = false;
                NPC.moveon();
            }
        }
    }
}
