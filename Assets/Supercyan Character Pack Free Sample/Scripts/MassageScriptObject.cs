using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/MassageAndQuestion", order = 1)]
public class MassageScriptObject : ScriptableObject
{
    [Multiline] public string[] Messages;
    [Multiline] public string Question;
    public string[] Examples;
    public int Answer;
    public int Point;
}