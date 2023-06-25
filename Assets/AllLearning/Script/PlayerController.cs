using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour, IDamageable<float>, IKillable
{
    [SerializeField] private Data Data;
    private float health;
    public static float Pdamage;
    private float speed;

    private Rigidbody2D playerRB;
    private void Awake()
    {
        health = Data.Health;
        Pdamage = Data.Damage;
        speed = Data.Speed;
    }
    private void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }
    public void Damage(float damage)
    {
        health -= damage;
    }

    public void Kill()
    {
        Destroy(this.gameObject);
    }
    private void Update()
    {
        if (health <= 0)
        {
            Kill();
        }
    }

    private void FixedUpdate()
    {
        float enemyMove = Input.GetAxisRaw("Horizontal");

        playerRB.velocity = new Vector2(enemyMove * speed, playerRB.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Damage(EnemyController.Edamage);
            Debug.Log("Player :" + health);
        }
    }
}
