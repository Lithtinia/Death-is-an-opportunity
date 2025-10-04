using System.Collections;
using UnityEngine;

public class GameMananger : MonoBehaviour
{
    // how we keep track of ppl in line and our choice 
    public float PplInLine;
    public float CorrectC;
    public carmovment carmovment;
    public sceneswapper ss;
    public GameObject choicetracker;
    void Start()
    {
        PplInLine = 4;
       
    }
    
    // Update is called once per frame
    public void FixedUpdate()
    {
        StartCoroutine(tempttimer());
        if (PplInLine == 0)
        {
            // we do next day/ good end v bad end math
            if (CorrectC > 3)
            {
                ss.goodend();
            }
            else if (CorrectC <3)

            {
                ss.badend();
            }
        }
    }

    IEnumerator tempttimer()
    {
        WaitForSeconds wait = new WaitForSeconds(3f);
        carmovment.enabled = true;
        yield return wait;
    }
}
