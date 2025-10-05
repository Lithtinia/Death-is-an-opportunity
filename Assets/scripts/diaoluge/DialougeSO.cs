using System;
using UnityEngine;

[CreateAssetMenu(fileName = "DialougeSO", menuName = "Scriptable Objects/DialougeSO")]
public class DialougeSO : ScriptableObject
{
    public Actors[] actors;
    //public Sprite charater;

    //public String Name;

[Header("boring talking stuff")]
[TextArea]
    public string[] Talking;
}
