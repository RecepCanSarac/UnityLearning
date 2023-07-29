using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TowerKalıtım : Towers
{
    public TowerKalıtım(float damage,float fireRate,int attackRange,int upgradePrice)
    {
        this.damage = damage;
        this.fireRate = fireRate;
        this.attackRange = attackRange;
        this.upgradePrice = upgradePrice;


    }
}
