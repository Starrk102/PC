using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewUniversalScriptableObject", menuName = "UniversalScriptableObject", order = 51)]
public class UniversalScriptableObject : ScriptableObject
{
    [SerializeField]
    public float Mood;
}
