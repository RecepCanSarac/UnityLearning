using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMpve : MonoBehaviour
{
    public EnemyManager EnemyManager;
    private float health;
    private float damage;
    void Start()
    {
        health = EnemyManager.Health;
        damage = EnemyManager.Damage;
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.Space))
        {
            health -= 10;
            Debug.Log(health);
        }
    }
}
