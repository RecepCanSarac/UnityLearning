using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Towers
{
    public float damage;
    public float fireRate;
    public int attackRange;
    public int upgradePrice;
    public LayerMask targetLayer;
    public GameObject bullet;
    public TowerUpgradeItem[] towerUpgrade;
}

[System.Serializable]
public class TowerUpgradeItem
{
    public Sprite upSprite;
    public Sprite downSprite;
}
