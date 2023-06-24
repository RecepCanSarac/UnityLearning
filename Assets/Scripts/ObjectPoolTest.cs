using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolTest : MonoBehaviour
{
    [SerializeField] private float spawnInterval = 1;

    [SerializeField] private ObjectPool objectPool = null;
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    private IEnumerator SpawnRoutine()
    {
        int count = 0;
        while (true)
        {
           
            GameObject obj = objectPool.GetPooledObject(count++ % 2);

            obj.transform.position = Vector3.zero;
            yield return new WaitForSeconds(spawnInterval);

        }
    }
}
