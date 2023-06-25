using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private Data Data;
    private float health;
    public static float Edamage;
    private float speed;
    private float gold;

    private void Awake()
    {
        health = Data.Health;
        speed = Data.Speed;
        Edamage = Data.Damage;
        gold = Data.Gold;
    }
    void Start()
    {

    }


    void Update()
    {
        float platform = Mathf.PingPong(Time.time, 10);
        transform.position = new Vector3(platform, transform.position.y, transform.position.z);
    }
}
