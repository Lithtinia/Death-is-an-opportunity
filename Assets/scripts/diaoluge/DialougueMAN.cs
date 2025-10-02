using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Vivi;
public class DialougueMAN : MonoBehaviour
{
    private DialougeSO CC;
    private int stepnum;
    private bool TT;
    private String CName;
    private Sprite CPortage;
        
    public GameObject UIDia;
    public TMP_Text Playername;
    public Image oc;
    public TMP_Text talky;
    public ActorsSO[] ASO;
    void Start()
    {
       UIDia.SetActive(false);
    }
    
    // Update is called once per frame
    void Update()
    {
        if (TT && Input.GetKeyDown(KeyCode.T))
        {
            if (stepnum >= CC.actors.Length)
            {
                ST();
            }
            else
            {
                playtalk();
            }
        }
    }

    public void playtalk()
    {
        if (CC.actors[stepnum] == Actors.Random)
        {
            SetActorInfor(false);
            
        }
        else
        {
            SetActorInfor(true);
        }
        Playername.text = CName;
        oc.sprite = CPortage;
        talky.text = CC.Talking[stepnum];
        UIDia.SetActive(true);
        stepnum += 1;
    }
    public void StartT(TalkingStart TS)
    {
        CC = TS.Converations[0];
        //  Debug.Log("hate life");
        TT = true;
      
    }
    public void SetActorInfor(bool PP)
    {
        if (PP)
        {
            for (int i = 0; i < ASO.Length; i++)
            {
                if (ASO[i].name == CC.actors[stepnum].ToString())
                {
                    CName = ASO[i].Names;
                    CPortage = ASO[i].charaters;
                }
               
            }
        }
        else
        {
        }
    }

    public void ST()
    {
        stepnum = 0;
        TT = false;
        UIDia.SetActive(false);
    }
    
   
}



public enum Actors /// don't change random
{
    Zephyr,
    Furina,
    Tamisra,
    Carmilla,
    Random
};
