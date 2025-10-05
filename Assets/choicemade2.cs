using UnityEngine;
using Vivi;
public class choicemade2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public soulcarstuff SCS;
    public GameMananger GM;

    public void OnTriggerEnter(Collider other)
    {
        SCS = other.gameObject.GetComponent<soulcarstuff>();
        GM.PplInLine = GM.PplInLine - 1;
       
        if (SCS.bad == true)
        {
            GM.CorrectC = GM.CorrectC+ 1;
           
        }
       
        Destroy(other.gameObject);
    }
}
