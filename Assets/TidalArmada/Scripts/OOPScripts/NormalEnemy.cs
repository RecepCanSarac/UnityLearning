using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class NormalEnemy : Enemys
{
    public NormalEnemy(float Health,float Speed,float Damage,float Gold)
    {
        this.health = Health;
        this.speed = Speed;
        this.damage = Damage;
        this.gold = Gold;
    }
}