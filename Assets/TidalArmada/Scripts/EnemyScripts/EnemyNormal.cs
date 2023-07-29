using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyNormal : MonoBehaviour
{
    [Header("Enemy")]
    public NormalEnemy EnemySwim = new NormalEnemy(100,250,3,5);

    [Header("Features")]
    public GoldAndScore goldAndScore;
    public Transform target;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            EnemySwim.health -= 10;
        }

        if (EnemySwim.health <= 0)
        {
            goldAndScore.gold += EnemySwim.gold;
            Destroy(this.gameObject);
        }
        EnemyMove();  
    }
    

    private void EnemyMove()
    {
        transform.position = Vector3.Slerp(transform.position,target.position,0.01f);
    }

}
