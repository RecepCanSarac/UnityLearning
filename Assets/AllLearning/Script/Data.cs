using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Data",menuName ="Data")]
public class Data : ScriptableObject
{
    public float Health;
    public float Damage;
    public float Speed;
    public int Gold;
}
