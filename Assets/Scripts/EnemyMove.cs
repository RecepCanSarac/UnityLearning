using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class EnemyMove : MonoBehaviour
{
    public NavMeshAgent Agent;
    public Vector3 newPos;
  
   
    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
        newPos = new Vector3(transform.position.x + Random.Range(-40,45),transform.position.y,transform.position.z + Random.Range(-40, 45));
        Agent.SetDestination(newPos);
    }

    
    void Update()
    {
    

        if (Agent.remainingDistance < 1)
        {
            newPos = new Vector3(transform.position.x + Random.Range(-40, 45), transform.position.y, transform.position.z + Random.Range(-40, 45));
            Agent.SetDestination(newPos);
        }
    }
}
