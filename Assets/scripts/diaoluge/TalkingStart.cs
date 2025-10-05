using UnityEngine;

namespace Vivi
{
    public class TalkingStart : MonoBehaviour
    {
        public DialougeSO[] Converations;

        public DialougueMAN DM;

    

// public SpriteRenderer speachbyble;
        //private bool TalkingStarted;

        void Start()
        {
           // DM = GameObject.Find("GameMan").GetComponent<DialougueMAN>();
           //  speachbyble.enabled = false;
        }

        // Update is called once per frame
        public void OnTriggerStay(Collider other)
        {
           // speachbyble.enabled = true;
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (other.gameObject.CompareTag("Player"))
                {
                    DM.StartT(this);
                    //  TalkingStarted = true
                }

            }
        }
    }
}