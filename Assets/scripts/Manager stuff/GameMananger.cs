using UnityEngine;

public class GameMananger : MonoBehaviour
{
    // how we keep track of ppl in line and our choice 
    public float PplInLine;
    public float CorrectC;

    public sceneswapper ss;
    public GameObject choicetracker;
    void Start()
    {
        PplInLine = 5;
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
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
}
