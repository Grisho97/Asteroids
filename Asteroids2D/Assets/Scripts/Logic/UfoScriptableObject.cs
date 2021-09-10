using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/UfoSO", fileName = "UfoSO")]
[System.Serializable]
public class UfoScriptableObject : ScriptableObject
{
    public static UfoScriptableObject S; 

    public UfoScriptableObject()
    {
        S = this;
    }

    public float speed = 3f;
    public int pointsForUfo = 300;

}
