using System;
using UnityEngine;
using Vivi;

namespace Vivi
{
public class NPCmovement : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody RB;
    public object npcm;


    public void Start()
    {
       moveon();
    }

    void FixedUpdate()
    { 
        if (Input.GetKeyDown(KeyCode.I))
        {
            
            moveon();
            
        }
        
       
    }

    // Update is called once per frame
    public void moveon()
    {
        RB.AddForce(Vector3.left * speed);
    }

    public void stop()
    {
        RB.linearVelocity = Vector3.zero;
    }

    public void drop()
    {
        RB.useGravity = true;
    }
}
}