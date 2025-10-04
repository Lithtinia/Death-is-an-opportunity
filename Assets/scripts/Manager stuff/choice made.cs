using System;
using UnityEngine;

public class choicemade : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public soulcarstuff SCS;
    public GameMananger GM;

   public void OnTriggerEnter(Collider other)
   {
       SCS = other.gameObject.GetComponent<soulcarstuff>();
       GM.PplInLine = GM.PplInLine - 1;
       
       if (SCS.good == true)
       {
           GM.CorrectC = GM.CorrectC+ 1;
           
       }
       
       Destroy(other.gameObject);
   }
}
